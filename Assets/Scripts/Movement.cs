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
using ExtensionMethods;
#endregion

public class Movement : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private Rigidbody rb;

    #endregion
    
    #region Methods

    /// <summary>
    /// <see cref="Awake"/> is called before Start
    /// </summary>
    void Awake()
    {
        rb = gameObject.GetAddComponent<Rigidbody>();
    }

    /// <summary>
    /// <see cref="Start"/> is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// <see cref="Update"/> is called once per frame
    /// </summary>
    void Update()
    {

    }
    #endregion Methods
}
