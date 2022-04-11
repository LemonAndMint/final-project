using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getInputFromShell : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    var input = gameObject.GetComponent<InputField>();
    var se = new InputField.OnChangeEvent();
    se.AddListener(SubmitName);
    input.onValueChanged = se;
  }
  private void SubmitName(string arg0)
  {
    string[] words = arg0.Split('\n');
    if (words[words.Length - 1] == "")
		{
      Debug.Log(words[words.Length - 2]);
    }
  }

  // Update is called once per frame
  void Update()
  {
  }
}