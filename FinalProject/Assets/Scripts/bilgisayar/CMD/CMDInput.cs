using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CMDInput : MonoBehaviour
{
  InputField input;
  InputField.OnChangeEvent changeEvent;
  shell cmd;
  void Start()
  {
    input = GetComponent<InputField>();
    changeEvent = new InputField.OnChangeEvent();
    cmd = new shell();

    changeEvent.AddListener(SubmitName);
    input.onValueChanged = changeEvent;
  }
  private void SubmitName(string args)
  {
    //Girilen tüm harfleri içinde tutar.
    //#TODO: Zamanla birikecek bufferi temizle.
    //#TODO: Boş karakter girildiğinin kontrolünü yap.
    string[] words = args.Split('\n');
    if (words[words.Length - 1] == "")
		{
      //Debug.Log(words[words.Length - 2]); //#FIXME ekranda ilk yazılan şey silinince OOB hatası veriyor
      cmd.getCommand(words[words.Length - 2]);
    }
  }
}