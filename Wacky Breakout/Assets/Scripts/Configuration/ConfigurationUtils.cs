using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configData;
    #region Properties
    
    
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configData.PaddleMoveUnitsPerSecond; }
    }
    public static float BallImpulseForce
    {
        get { return configData.BallImpulseForce; }
    }
    public static float BallLifetime
    {
        get { return configData.BallLifetime; }
    }
    public static float MinSpawnTime {
        get { return configData.MinSpawnTime; }
    }
    public static float MaxSpawnTime
    {
        get { return configData.MaxSpawnTime; }
    }
    public static float StandardBrickPoint
    {
        get { return configData.StandardBrickPoint; }
    }
    public static float BonusBrickPoint
    {
        get { return configData.BonusBrickPoint; }
    }
    public static float PickupBrickPoint
    {
        get { return configData.PickupBrickPoint; }
    }


    #endregion


    public static void Initialize()
    {
        configData = new ConfigurationData();
    }
}
