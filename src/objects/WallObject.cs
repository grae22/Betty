using System;

namespace Betty
{
  public abstract class WallObject : IComparable< WallObject >
  {
    //-------------------------------------------------------------------------

    public abstract string Description
    {
      get;
    }

    //-------------------------------------------------------------------------

    public abstract string ShortDescription
    {
      get;
    }

    //-------------------------------------------------------------------------

    public abstract int CompareTo( WallObject ob );

    //-------------------------------------------------------------------------
  }
}
