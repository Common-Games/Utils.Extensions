using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	[PublicAPI]
    public static class StringExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Boolean IsNullOrWhiteSpace(this String input) 
			=> String.IsNullOrWhiteSpace(input);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Boolean IsNullOrEmpty(this String input) 
			=> String.IsNullOrEmpty(input);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Boolean NotNullOrWhiteSpace(this String input) 
			=> !String.IsNullOrWhiteSpace(input);
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Boolean NotNullOrEmpty(this String input) 
			=> !String.IsNullOrEmpty(input);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Boolean StartsWithAny(this String input, params String[] options)
		{
			foreach (String __option in options)
			{
				if (input.StartsWith(__option)) return true;
			}

			return false;
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static (String matchingPart, String nonMatchingLHS, String nonMatchingRHS) SplitAtDeviation(this String lhs, in String rhs)
		{
			if(lhs.IsNullOrWhiteSpace() || rhs.IsNullOrWhiteSpace()) return (null, lhs, rhs);
            
			String __shortestString = (lhs.Length >= rhs.Length) ? rhs : lhs;

			String 
				__matchingPart = null,
				__nonMatchingA = lhs,
				__nonMatchingB = rhs;
            
			for(Int32 __index = 0; __index < __shortestString.Length; __index++)
			{
				/*
				UnityEngine.Debug.Log(message:  "\n" +
										$"A = {lhs}\n" +
										$"B = {b}\n" +
										$"Index = {__index}\n" +
										$"Char A = {lhs[__index]}\n" +
										$"Char B = {b[__index]}");
										*/
                
				if(lhs[__index] == rhs[__index]) continue;

				__matchingPart = __shortestString.Substring(startIndex: 0, length: __index);

				__nonMatchingA = lhs.Substring(startIndex: __index, length: lhs.Length-__index);
                    
				__nonMatchingB = rhs.Substring(startIndex: __index, length: rhs.Length-__index);
                    
				break;
			}

			return (__matchingPart, __nonMatchingA, __nonMatchingB);
		}

		public static String ToPathFormatting(this String value) => value.Replace(oldChar: Path.AltDirectorySeparatorChar, newChar: Path.DirectorySeparatorChar);
		
		public static String ToUnityFormatting(this String value) => value.Replace(oldChar: Path.DirectorySeparatorChar, newChar: Path.AltDirectorySeparatorChar);

		/// <summary> Re-bases lhs path to be relative to the "<paramref name="to"></paramref>" path. </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static String MakeRelative(this String value, String to)
		{
			if (value.IsNullOrEmpty()) throw new ArgumentNullException(paramName: nameof(value));
			if (to.IsNullOrEmpty()) throw new ArgumentNullException(paramName: nameof(to));

			value = value.ToPathFormatting().AppendDirectorySeparator();
			to    = to.ToPathFormatting().AppendDirectorySeparator();

			Debug.Log($"from = {value}, to = {to}");

			Uri __fromURI = new Uri(value);
			Uri __toURI   = new Uri(to);
			
			if (__fromURI.Scheme != __toURI.Scheme) return to;

			Uri __relativeUri = __fromURI.MakeRelativeUri(__toURI);
			String __relativePath = Uri.UnescapeDataString(stringToUnescape: __relativeUri.ToString());
			
			if (String.Equals(a: __toURI.Scheme, b: Uri.UriSchemeFile, comparisonType: StringComparison.OrdinalIgnoreCase))
			{
				__relativePath = __relativePath.Replace(oldChar: Path.AltDirectorySeparatorChar, newChar:Path.DirectorySeparatorChar);
			}

			return __relativePath;

			//return Uri.UnescapeDataString(stringToUnescape: __relativeTo.MakeRelativeUri(__fullPath).ToString());
			//return Uri.UnescapeDataString(stringToUnescape: __relativeTo.MakeRelativeUri(__fullPath).ToString()).ToPathFormatting();
		}

		public static Boolean IsValidDirectory(this String path) => Directory.Exists(path);
		
		public static Boolean NotValidDirectory(this String path) => !Directory.Exists(path);
		
		public static String AppendDirectorySeparator(this String path)
		{
			Boolean __isFile = Path.HasExtension(path);
			Boolean __hasSeparator = path.EndsWith(value: Path.DirectorySeparatorChar.ToString()) || path.EndsWith(value: Path.AltDirectorySeparatorChar.ToString());

			if (__isFile || __hasSeparator) return path;
			
			return path + Path.DirectorySeparatorChar;
		}
		
		public static String Remove(this String value, in String text) => value.Replace(oldValue: text, newValue: String.Empty);

		/// <summary> Re-bases lhs path to be relative to the "<paramref name="to"></paramref>" path. </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static String MakeRelativeTo(this String from, in String to)
		{
			StringBuilder __path = new StringBuilder(260); // MAX_PATH
			if(PathRelativePathTo(__path, from, attrFrom: __GetPathAttribute(from), to, attrTo: __GetPathAttribute(to)))
			{
				return __path.ToString();
			}
			
			throw new ArgumentException(message: "Paths must have lhs common prefix");
			
			
			static Int32 __GetPathAttribute(in String path)
			{
				if(IsDirectory(path)) return 0x10;
				if(IsFile(path))      return 0x80;
				throw new FileNotFoundException();
			}
		}
		
		[DllImport(dllName: "shlwapi.dll", SetLastError = true)]
		private static extern Boolean PathRelativePathTo(StringBuilder builder, String from, Int32 attrFrom, String to, Int32 attrTo);

		public static Boolean IsDirectory(String path)
		{
			DirectoryInfo __dir = new DirectoryInfo(path);
			return __dir.Exists;
		}

		public static Boolean IsFile(String path)
		{
			FileInfo __file = new FileInfo(path);
			return __file.Exists;
		}

		public static String RemoveInvalidFileNameCharacters(this String input)
			=> String.Concat(values: input.Split(separator: Path.GetInvalidFileNameChars()));
		
		public static String ReplaceInvalidFileNameCharacters(this String input, in Char replaceWith = '_')
			=> String.Join(separator: replaceWith.ToString(), value: input.Split(separator: Path.GetInvalidFileNameChars()));

		public static String MakeValidScriptName(this String input)
			=> input.RemoveInvalidFileNameCharacters().Replace(oldChar: ' ', newChar: '_');

		/*
		//Stolen from this blog, for learning purposes, but I found it useful.
		public static int Count(this string text, char c)
		{
		    ReadOnlySpan<char> span = text.AsSpan();
		    ref char r0 = ref MemoryMarshal.GetReference(span);
		    int length = span.Length;
		    int i = 0, result;
				
		    if (Vector.IsHardwareAccelerated)
		    {
		        int end = length - Vector<ushort>.Count;

		        // SIMD register all set to 0, to store partial results
		        Vector<ushort> partials = Vector<ushort>.Zero;

		        // SIMD register with the target character c copied in every position
		        Vector<ushort> vc = new Vector<ushort>(c);

		        for (; i <= end; i += Vector<ushort>.Count)
		        {
		            // Get the reference to the current characters chunk
		            ref char ri = ref Unsafe.Add(ref r0, i);

					// vi = { text[i], ..., text[i + Vector<char>.Count - 1] }
		            Vector<ushort> vi = Unsafe.As<char, Vector<ushort>>(ref ri);


		            Vector<ushort> ve = Vector.Equals(vi, vc);


		            Vector<ushort> va = Vector.BitwiseAnd(ve, Vector<ushort>.One);

		            // Accumulate the partial results in each position
		            partials += va;
		        }
				
		        result = Vector.Dot(partials, Vector<ushort>.One);
		    }
		    else result = 0;

		    // Iterate over the remaining characters and count those that match
		    for (; i < length; i++)
		    {
		        bool equals = Unsafe.Add(ref r0, i) == c;
		        result += Unsafe.As<bool, byte>(ref equals);
		    }

		    return result;
		}
		*/
	}
}
