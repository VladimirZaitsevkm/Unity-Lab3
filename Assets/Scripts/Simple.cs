using UnityEngine;

public class Simple : MonoBehaviour
{
  private void Awake()
  {
    Debug.Log("I Awake");
  }

  private void OnEnable()
  {
    Debug.Log("I OnEnable");
  }

  private void Start()
  {
    Debug.Log("I Start");
  }

  private void Update()
  {
    Debug.Log("I Update");
  }

  private void FixedUpdate()
  {
    Debug.Log("I FixedUpdate");
  }

  private void LateUpdate()
  {
    Debug.Log("I LateUpdate");
  }

  private void OnDisable()
  {
    Debug.Log("I OnDisable");
  }

  private void OnDestroy()
  {
    Debug.Log("I OnDestroy");
  }
}