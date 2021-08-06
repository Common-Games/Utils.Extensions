using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

using Object = UnityEngine.Object;

namespace CGTK.Utilities.Extensions
{
    [PublicAPI]
    public static class ReflectionExtensions 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean TryGetAttribute<T>(this MemberInfo element, out T customAttribute) where T : Attribute
        {
            customAttribute = (T)element.GetCustomAttribute(attributeType: typeof(T));

            return (customAttribute == null);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean HasAttribute(this Type type, in Type attributeType)
            => Attribute.IsDefined(element: type, attributeType: attributeType);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean TryGetField(this Object target, String fieldName, out FieldInfo fieldInfo)
        {
            fieldInfo = target.AllFields(field => field.Name.Equals(fieldName, StringComparison.Ordinal)).FirstOrDefault();

            return (fieldInfo == null);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean TryGetProperty(this Object target, String propertyName, out PropertyInfo propertyInfo)
        {
            propertyInfo = target.AllProperties(property => property.Name.Equals(propertyName, StringComparison.Ordinal)).FirstOrDefault();

            return (propertyInfo == null);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean TryGetMethod(this Object target, String methodName, out MethodInfo methodInfo)
        {
            methodInfo = target.AllMethods(method => method.Name.Equals(methodName, StringComparison.Ordinal)).FirstOrDefault();

            return (methodInfo == null);
        }
		    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean TryGetMember(this Object target, String memberName, out MemberInfo memberInfo)
        {
            memberInfo = target.AllMembers(member => member.Name.Equals(memberName, StringComparison.Ordinal)).FirstOrDefault();

            return (memberInfo == null);
        }
        
        
        private const BindingFlags _FLAGS = (BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static IEnumerable<MethodInfo> AllMethods(this System.Object target, Func<MethodInfo, Boolean> predicate)
            => GetAll(target, getMembersFn: type => type.GetMethods(bindingAttr: _FLAGS).Where(predicate));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static IEnumerable<FieldInfo> AllFields(this System.Object target, Func<FieldInfo, Boolean> predicate)
            => GetAll(target, getMembersFn: type => type.GetFields(bindingAttr: _FLAGS).Where(predicate));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static IEnumerable<PropertyInfo> AllProperties(this System.Object target, Func<PropertyInfo, Boolean> predicate)
            => GetAll(target, getMembersFn: type => type.GetProperties(bindingAttr: _FLAGS).Where(predicate));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static IEnumerable<MemberInfo> AllMembers(this System.Object target, Func<MemberInfo, Boolean> predicate)
            => GetAll(target, getMembersFn: type => type.GetMembers(bindingAttr: _FLAGS).Where(predicate));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static IEnumerable<T> GetAll<T>(System.Object target, Func<Type, IEnumerable<T>> getMembersFn)
        {
            if (target == null)
            {
                Debug.LogError(message: "The target object is null.");
                yield break;
            }

            List<Type> __types = target.GetSelfAndBaseTypes();
            
            for (Int32 __index = __types.Count - 1; __index >= 0; __index--)
            {
                IEnumerable<T> __infos = getMembersFn(arg: __types[index: __index]);

                foreach (T __info in __infos)
                {
                    yield return __info;
                }
            }
        }
        
        /// <summary> Get type and all base types of <paramref name="input"/> </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static List<Type> GetSelfAndBaseTypes(this System.Object input)
        {
            List<Type> __types = new List<Type>
            {
                input.GetType()
            };

            while (__types.Last().BaseType == null)
            {
                __types.Add(item: __types.Last().BaseType);
            }

            return __types;
        }
        
    }
}
