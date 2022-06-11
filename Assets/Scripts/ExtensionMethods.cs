#region Copyright (c)
/****************************************
 * Copyright (c) All rights reserved to
 * !NullBool, NotNullBool
 * Contact info: notnullbool@gmail.com
 ****************************************/ 
#endregion

#region Imports
using System.Collections;
using System.Collections.Generic;
using static LanguageExt.Prelude;
using UnityEngine;
using System.Diagnostics.Contracts;
using System;
#endregion

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        #region Variables

        #endregion
        
        #region Methods
        /// <summary>
        /// Get component from current object if not add it 
        /// </summary>
        /// <param name="gameObject"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        [Pure]
        public static T GetAddComponent<T>(this GameObject gameObject) where T : Component => 
        gameObject.GetComponent<T>().NullObjToNull() ?? gameObject.AddComponent<T>();
        /// <summary>
        /// Get component from current object if not add it 
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="componentType"></param>
        /// <returns><paramref name="componentType"/></returns>
        public static Component GetAddComponent(this GameObject gameObject, Type componentType) => 
        gameObject.GetComponent(componentType).NullObjToNull() ?? gameObject.AddComponent(componentType);
        

        /// <summary>
        /// Set this to a new variable.
        /// Useful to save variable from conditionals.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="obj"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T AddToScope<T>(this T @this,out T obj) => obj = @this;

        /// <summary>
        /// Convert Unity Null Object to System Null
        /// Useful to use ?? and ??= operators
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        [Pure]
        public static T NullObjToNull<T>(this T @this) where T : UnityEngine.Object => !@this ? null : @this as T; 
        #endregion Methods
    }
}
