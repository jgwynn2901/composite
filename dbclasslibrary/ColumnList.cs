using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DbClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class ColumnList : IEnumerable<Column>
    {
        private readonly Dictionary <string, Column> _columns = new Dictionary<string, Column>();
        private readonly Dictionary<int, string> _map = new Dictionary<int, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnList"/> class.
        /// </summary>
        public ColumnList()
        {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnList"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public ColumnList(IEnumerable<Column> source)
        {
          foreach (var column in source.Where(column => column != null))
            Add(column);
        }

      /// <summary>
        /// Gets the <see cref="DbClassLibrary.Column"/> at the specified index.
        /// </summary>
        /// <value></value>
        public Column this[string name]
        {
            get
            {
              return _columns.ContainsKey(name) ? _columns[name] : default(Column);
            }
        }

        /// <summary>
        /// Gets the <see cref="DbClassLibrary.Column"/> at the specified index.
        /// </summary>
        /// <value></value>
        public Column this[int index]
        {
            get
            {
                return _columns.Count > index
                           ? _columns[_map[index]]
                           : default(Column);

            }
        }

        /// <summary>
        /// Adds the specified new column.
        /// </summary>
        /// <param name="newColumn">The new column.</param>
        public void Add (Column newColumn)
        {
            _map.Add(_columns.Count,newColumn.Name);
            _columns.Add(newColumn.Name, newColumn);
        }

        /// <summary>
        /// Not the best way to convert name to index but there it is.
        /// </summary>
        /// <param name="name">The name.</param>
        public int IndexOf(string name)
        {
            foreach (var pair in _map)
                if (pair.Value == name)
                    return pair.Key;
            return -1;
        }
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return _columns.Count; } }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            _columns.Clear();
            _map.Clear();
        }

        /// <summary>
        /// Toes the list.
        /// </summary>
        /// <returns></returns>
        public List<Column> ToList()
        {
            return _columns.Values.ToList();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<Column> GetEnumerator()
        {
            return _columns.Values.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
