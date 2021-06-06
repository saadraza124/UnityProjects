using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public  class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    static float paddleMoveUnitsPerSecond = 1;
    static float ballImpulseForce = 5;
    static float ballLifetime = 5;
    static float minSpawnTime = 5;
    static float maxSpawnTime = 10;
    static float standardBrickPoint = 5;
    static float bonusBrickPoint = 50;
    static float pickupBrickPoint = 50;

    #endregion

    #region Properties


    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }
    public float BallLifetime {
        get { return ballLifetime; }
    }
    public float MinSpawnTime {
        get { return minSpawnTime; }
    }
    public float MaxSpawnTime
    {
        get { return maxSpawnTime; }
    }
    public float StandardBrickPoint
    {
        get { return standardBrickPoint; }
    }
    public float BonusBrickPoint
    {
        get { return bonusBrickPoint; }
    }
    public float PickupBrickPoint
    {
        get { return pickupBrickPoint; }
    }
    #endregion

    #region Constructor


    public ConfigurationData()
    {
        StreamReader reader = null;
        try
        {
            reader = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName));
            string names = reader.ReadLine();
            string values = reader.ReadLine();
            SetConfigurationDataFields(values);
        }

        catch (Exception e) { }
        finally
        {
            if (reader != null) { reader.Close(); }
        }
    }
    static void SetConfigurationDataFields(string csvValues)
    {
        string[] values = csvValues.Split(',');
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifetime = float.Parse(values[2]);
        minSpawnTime = float.Parse(values[3]);
        maxSpawnTime = float.Parse(values[4]);
        standardBrickPoint = float.Parse(values[5]);
        bonusBrickPoint = float.Parse(values[6]);
        pickupBrickPoint = float.Parse(values[7]);


    }

    #endregion
}
