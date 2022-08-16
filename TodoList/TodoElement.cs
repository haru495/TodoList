using System;

public class TodoElement
{
	public TodoElement(string Element, bool DoneFlg)
	{
		this.Element = Element;
		this.DoneFlg = DoneFlg;
	}

	public string Element { get; set; }
	public bool DoneFlg { get; set; }
}

