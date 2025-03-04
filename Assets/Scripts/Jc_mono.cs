using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jc_mono : MonoBehaviour
{
    void Awake()
    {
        Debug.Log($"Время Awake: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void OnEnable()
    {
        Debug.Log($"Время OnEnable: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void Start()
    {
        Debug.Log($"Время Start: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void FixedUpdate()
    {
        Debug.Log($"Время FixedUpdate: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void Update()
    {
        Debug.Log($"Время Update: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void LateUpdate(){
        Debug.Log($"Время LateUpdate: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void OnApplicationPause(bool pauseStatus){
        string status = pauseStatus ? "Пауза" : "Нет паузы";
        Debug.Log($"Время OnApplicationPause, сейчас {status}: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void OnApplicationQuit(){
        Debug.Log($"Время OnApplicationQuit: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void OnDisable(){
        Debug.Log($"Время OnDisable: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
    void OnDestroy(){
        Debug.Log($"Время OnDestroy: {DateTime.Now.ToString("HH:mm:ss.fff")}");
    }
}
