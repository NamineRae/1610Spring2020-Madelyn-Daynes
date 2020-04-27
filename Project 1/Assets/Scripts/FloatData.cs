using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
  public float value = 1f;

  public void ChangeCalue(float number)
  {
    value += number;
  }

  public void ValueSet(float number)
  {
    value = number;
  }
}
//good for keeping track of health points