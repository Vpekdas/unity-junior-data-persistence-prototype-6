using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Build.Content;
using UnityEngine;

/// <summary>
/// Subclass of Unit that will increase production of a Resource Pile.
/// </summary>
public class ProductivityUnit : Unit
{

    protected override void BuildingInRange()
    {
        if (m_Target.TryGetComponent<ResourcePile>(out var resourcePile))
        {
            if (!resourcePile.HasBeenBoosted)
            {
                resourcePile.ProductionSpeed *= 2.0f;
                resourcePile.HasBeenBoosted = true;
            }
        }
    }

    //Override all the UI function to give a new name and display what it is currently doing.
    public override string GetName()
    {
        return "Productivity Unit";
    }

    public override string GetData()
    {
        return $"Can increase productivity up to 2 times.";
    }
}
