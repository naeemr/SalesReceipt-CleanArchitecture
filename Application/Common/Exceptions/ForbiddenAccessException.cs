﻿using System;

namespace Application.Common;

public class ForbiddenAccessException : Exception
{
	public ForbiddenAccessException() : base() { }
}
