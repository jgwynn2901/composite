using System.Runtime.InteropServices;
namespace DbClassLibrary.Opm
{
	///<summary>
	/// used in Creating Outcome step records
	///</summary>
	[Guid("59712911-3969-4d3d-AB13-7B3CE9BB15EA")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ISequenceStep
	{
		/// <summary>
		/// Gets the alt destination string.
		/// </summary>
		/// <value>The alt destination string.</value>
		string AltDestinationString { get; }
		/// <summary>
		/// Gets the batch hold.
		/// </summary>
		/// <value>The batch hold.</value>
		string BatchHold { get;  }
		/// <summary>
		/// Gets the destination string.
		/// </summary>
		/// <value>The destination string.</value>
		string DestinationString { get;  }
		/// <summary>
		/// Gets the retry count.
		/// </summary>
		/// <value>The retry count.</value>
		string RetryCount { get; }
		/// <summary>
		/// Gets the retry wait time.
		/// </summary>
		/// <value>The retry wait time.</value>
		string RetryWaitTime { get; }
		/// <summary>
		/// Gets the routing plan id.
		/// </summary>
		/// <value>The routing plan id.</value>
		string RoutingPlanId { get;  }
		/// <summary>
		/// Gets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		string Sequence { get;  }
		/// <summary>
		/// Gets the transmission type id.
		/// </summary>
		/// <value>The transmission type id.</value>
		string TransmissionTypeId { get;  }
	}
}
