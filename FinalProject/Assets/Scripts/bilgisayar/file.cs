using System.Collections;
using System.Collections.Generic;

public class data
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

public class TextFile : file
{
  private string text; // yazı dosyasının içindeki yazı
  private string extension; // .xxx olan kısım buraya yazılacak
  
  public TextFile(string fname, string fdesc) : base(fname, fdesc) 
  {
    findExtension(fname);
  }

  private void findExtension(string name){
    extension = name.Split('.')[1]; // abc.xxx olan bir dosya isminde xxx kısmını alır.
  }
  public TextFile(string fname) : base(fname)
  {
    this.fdesc = "A Text file";  
  }
}