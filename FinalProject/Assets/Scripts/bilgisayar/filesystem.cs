using System.Collections;
using System.Collections.Generic;
using System.IO;

public class filesystem
{
	//file dosyalar, folder klasörlerdir.
	//en üstteki kök klasörü oluşturulur.
	public folder root = new folder();

	//destination, oluşturulacak klasörün konumu mesela
	//0,0,1,0
	//bu da root listesinde bulunan listelerde gezinmemiz anlamına geliyor.
	public void createFolder(int[] destination, string name) 
	{
		folder tempFold;
		//dosya sisteminde istenilen konumdaki klasöre erişilir.
		tempFold = travel(destination);
		//yeni klasör oluşturma kısmı
		folder newFolder = new folder(name);
		//bulunduğumuz klasörün sonuna yeni oluşturulan klasörü ekler.
		tempFold.slot.Add(newFolder);
	}

	//#TODO 1: dosya özellikleri sonradan belli olacak.
	public void createFile(int[] destination, string name)
	{
		folder tempFold;
		//dosya sisteminde istenilen konumdaki klasöre erişilir.
		tempFold = travel(destination);
		//yeni dosya oluşturma kısmı
		file newFile = new file(name);
		//bulunduğumuz klasörün sonuna yeni oluşturulan dosyayı ekler.
		tempFold.slot.Add(newFile);
	}

  public WebFile createWebFile(int[] destination, string name, Page page) //#TODO argümentleri array olarak alıp farklı yapıcılarda çalıştırma
	{
		folder tempFold;
		//dosya sisteminde istenilen konumdaki klasöre erişilir.
		tempFold = travel(destination);
		//yeni dosya oluşturma kısmı
		WebFile newFile = new WebFile(name, page);
		//bulunduğumuz klasörün sonuna yeni oluşturulan dosyayı ekler.
		tempFold.slot.Add(newFile);
    return newFile;
	}


	folder travel(int[] destination)
	{
		folder tempFold;
		tempFold = root;
		//destination arrayının uzunluğu bize kaç kaç derine gitmemiz gerektiğini söyler
		//her bir katta bulunduğumuz klasörün kaçıncı elamanındaki klasöre gitmemiz gerektiği
		//destination[i] arayinde bellidir.
		for (int i = 0; i < destination.Length - 1; i++)
		{
			//klasörde istenilen alan boşsa ya da bir klasör değilse
			if ((folder)tempFold.slot[destination[i]] == null && 
					tempFold.slot[destination[i]].GetType().Name != "folder")
			{
				throw new FileNotFoundException(); //istenilen klasöre ulaşılamadı hatası
			}
			tempFold = (folder)tempFold.slot[destination[i]];
		}
		return tempFold;
	}

  /*file search(string name){
    #TODO 
  }*/
}
