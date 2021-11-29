using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/Standart Enemy", fileName = "New Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private Sprite _enemyTexture;
    [SerializeField] private float _attack;
    [SerializeField] private float _diffence;
}
