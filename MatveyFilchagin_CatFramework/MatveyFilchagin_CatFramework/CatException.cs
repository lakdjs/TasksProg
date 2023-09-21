using System;

namespace MatveyFilchagin_CatFramework;

public class CatException: ArgumentException
{
    public CatException(string message) : base(message){}
}

