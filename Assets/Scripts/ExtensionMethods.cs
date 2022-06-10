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
        /// <returns></returns>
        [Pure]
        public static T GetAddComponent<T>(this GameObject gameObject) where T : Component => 
        gameObject.GetComponent<T>().OutToVar(out var component) != null ? component : gameObject.AddComponent<T>();

        /// <summary>
        /// Set this to a new variable.
        /// Useful to save variable from conditionals.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="obj"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T OutToVar<T>(this T @this,out T obj) => obj = @this;
        #endregion Methods
    }
}
