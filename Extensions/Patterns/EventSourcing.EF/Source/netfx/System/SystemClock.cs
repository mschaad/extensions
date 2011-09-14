﻿#region BSD License
/* 
Copyright (c) 2011, NETFx
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, 
are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list 
  of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice, this 
  list of conditions and the following disclaimer in the documentation and/or other 
  materials provided with the distribution.

* Neither the name of Clarius Consulting nor the names of its contributors may be 
  used to endorse or promote products derived from this software without specific 
  prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY 
EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES 
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT 
SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED 
TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR 
BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 
ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH 
DAMAGE.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Default implementation of <see cref="IClock"/> that exposes 
/// the <see cref="DateTime"/> default members.
/// </summary>
/// <devdoc>
/// To make this class public, create a partial class
/// definition in another code file and declare it as public.
/// This allows a seamless updates experience.
/// </devdoc>
///	<nuget id="netfx-System.Clock" />
partial class SystemClock : IClock
{
	static SystemClock()
	{
		Instance = new SystemClock();
	}

	private SystemClock()
	{
		// Hide default constructor.
	}

	/// <summary>
	/// Gets the singleton instance of the system clock.
	/// </summary>
	public static IClock Instance { get; private set; }

	/// <summary>
	/// Current date and time.
	/// </summary>
	public DateTime Now
	{
		get { return DateTime.Now; }
	}

	/// <summary>
	/// Current date and time in UTC format.
	/// </summary>
	public DateTime UtcNow
	{
		get { return DateTime.UtcNow; }
	}
}