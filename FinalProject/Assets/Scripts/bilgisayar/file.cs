using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class data : MonoBehaviour
{
  public string fname;
  public string fdesc;
}

public class folder : data
{
  public List<data> slot = new List<data>();
  public folder(string fname)
	{
    this.fname = fname;
    fdesc = "A folder";
  }
  //root oluşturmak için gerekli constructor
  public folder()
  {
    this.fname = "/";
    fdesc = "A folder";
  }
}

//#TODO 2: dosyalara özellikler ekle.
//#TODO 3: file çeşitleri ekle.
public class file : data
{
  public file(string fname, string fdesc)
	{
    this.fname = fname;
    this.fdesc = fdesc;
	}
  public file(string fname)
  {
    this.fname = fname;
    this.fdesc = "A file";
  }
}

public class WebPage : file
{
  //private string text; // yazı dosyasının içindeki yazı
  //private string extension; // .xxx olan kısım buraya yazılacak
  private GameObject page; 
  public WebPage(string fname, string fdesc) : base(fname, fdesc) 
  {
    //findExtension(fname);
  }

  /*private void findExtension(string name){
    extension = name.Split('.')[1]; // abc.xxx olan bir dosya isminde xxx kısmını alır.
  }*/
  public WebPage(string fname) : base(fname)
  {
    this.fdesc = "A Page";  
  }
}