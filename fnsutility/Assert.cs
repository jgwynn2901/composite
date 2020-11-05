#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2006 First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/Assert.cs 3     6/29/10 4:12p Gwynnj $ */
#endregion
using System;

namespace FnsUtility
{
  /// <summary>
  /// Summary description for Assert.
  /// </summary>
  public sealed class Assert
  {
    private const string ErrorMessage = "Assert.Test failed.";
    /// <summary>
    /// Probably, FailedException instances should be created
    /// only from within the Assert class.
    /// </summary>
    public sealed class FailedAssertionException : ApplicationException
    {
      /// <summary>
      /// Initializes a new instance of the <see cref="FailedAssertionException"/> class.
      /// </summary>
      /// <param name="s">The s.</param>
      public FailedAssertionException(string s) : base(s) { }
    }
    /// <summary>
    /// Tests the specified condition. Throws Application Exception on failure
    /// </summary>
    /// <param name="condition">if set to <c>true</c> [condition].</param>
    public static void Test(bool condition)
    {
      if (condition) { return; }
      throw new FailedAssertionException(ErrorMessage);
    }

    /// <summary>
    /// Determines whether the specified condition is true.
    /// </summary>
    /// <param name="condition">if set to <c>true</c> [condition].</param>
    public static void IsTrue(bool condition)
    {
      Test(condition, ErrorMessage);
    }

    /// <summary>
    /// Determines whether the specified condition is true.
    /// </summary>
    /// <param name="condition">if set to <c>true</c> [condition].</param>
    /// <param name="message">The message.</param>
    public static void IsTrue(bool condition, string message)
    {
      Test(condition, message);
    }

    /// <summary>
    /// Determines whether [is not null] [the specified test].
    /// </summary>
    /// <param name="test">The test.</param>
    public static void IsNotNull(object test)
    {
      IsNotNull(test, ErrorMessage);
    }

    /// <summary>
    /// Determines whether [is not null] [the specified test].
    /// </summary>
    /// <param name="test">The test.</param>
    /// <param name="message">The message.</param>
    /// <exception cref="FnsUtility.Assert.FailedAssertionException">Assert.Test failed: ' + message</exception>
    public static void IsNotNull(object test, string message)
    {
      if (test == null) throw new FailedAssertionException("Assert.Test failed: '" + message);
    }
    /// <summary>
    /// Tests the specified condition. Throws Application Exception(message) on failure
    /// </summary>
    /// <param name="condition">if set to <c>true</c> [condition].</param>
    /// <param name="message">The message.</param>
    public static void Test(bool condition, string message)
    {
      if (condition) { return; }
      throw new FailedAssertionException("Assert.Test failed: '" + message);
    }

    /// <summary>
    /// Determines whether [is not empty] [the specified test parameter].
    /// </summary>
    /// <param name="testParameter">The test parameter.</param>
    /// <param name="message">The message.</param>
    public static void IsNotEmpty(string testParameter, string message)
    {
      Test(!string.IsNullOrEmpty(testParameter), message);
    }
    /// <summary>
    /// Tests for null arguments.
    /// </summary>
    /// <param name="ob">The ob.</param>
    /// <param name="message">The message.</param>
    public static void TestNullArgument(object ob, string message)
    {
      if (ob != null) { return; }
      throw new ArgumentNullException("TestNullArgument failed: '" + message);
    }
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/Assert.cs $
 * 
 * 3     6/29/10 4:12p Gwynnj
 * Added IsNotEmpty assertion
 * 
 * 2     9/04/07 12:33p John.gwynn
 * make sure nunit reference has specific version property set to false
 * 
 * 1     1/18/07 2:38p John.gwynn
 * Framework 2.0 upgrade
 * 
 * 4     12/19/06 1:26p John.gwynn
 * NDoc comments for technical documentation see:
 * http://cha1saxc/wiki/ndocs/fnsutility/index.html
 * 
 * 3     10/17/06 11:46a John.gwynn
 * removed conditional compilation directives.  Asserts are now live in
 * all configurations and can be used reliably.
 * 
 * 2     5/13/06 1:49p John.gwynn
 * GlassPlus implementation support
 * 
 * 1     4/10/06 4:12p John.gwynn
 * New version with namespace fixed
 */
#endregion
