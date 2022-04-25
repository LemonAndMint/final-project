using System.Collections;
using System.Collections.Generic;

public class shell
{
	string[] parsdCmd; 
  public void getCommand(string command)
	{
		parser(command);
	}     

	private void parser(string command)
	{
		parsdCmd = command.Split(' ');
	}
	
	/*private void ()
	{
	//#TODO
	}*/
}
