﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.LibraryFeatures.Commands
{
	public interface ILibrariesCommand
	{
		void AddNewLibrary(string name, string address, string phone);
	}
}
