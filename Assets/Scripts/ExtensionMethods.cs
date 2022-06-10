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
#endregion

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        #region Variables

        #endregion
        
        #region Methods
        public static T GetAddComponent<T>(this GameObject gameObject) where T : Component => 
        gameObject.GetComponent<T>() != null ? gameObject.GetComponent<T>() : gameObject.AddComponent<T>();
        #endregion Methods
    }
}
