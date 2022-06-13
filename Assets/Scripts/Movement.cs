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
    private Rigidbody rigidBody;
    [SerializeField]
    private CharacterController characterController;

    #endregion
    
    #region Methods

    /// <summary>
    /// <see cref="Awake"/> is called before Start
    /// </summary>
    void Awake()
    {
        rigidBody = gameObject.IfNullGetAddComponent(rigidBody);
        rigidBody.freezeRotation = true;
        
        characterController =  gameObject.IfNullGetAddComponent(characterController);
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
        float speed = 1f * Time.deltaTime ;
        characterController.Move(transform.forward * speed);
    }
    #endregion Methods
}
