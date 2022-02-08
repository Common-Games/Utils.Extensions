using System;
using System.IO;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
	[PublicAPI]
	public static class DirectoryInfoExtensions
	{
		[MethodImpl(INLINE)]
		public static void RemoveFiles(this DirectoryInfo directory)
		{
			foreach (FileInfo __file in directory.GetFiles())
			{
				__file.Delete();  
			}
		}
		
		[MethodImpl(INLINE)]
		public static void RemoveFiles(this DirectoryInfo directory, in String fileExtensionToRemove)
		{
			if (String.IsNullOrEmpty(fileExtensionToRemove))
			{
				throw new ArgumentNullException(paramName: nameof(fileExtensionToRemove));
				//RemoveFiles(directory);
				//return;
			}

			foreach (FileInfo __file in directory.GetFiles())
			{
				if (__file.Extension == fileExtensionToRemove)
				{
					__file.Delete();       
				}
			}
		}
	}
}