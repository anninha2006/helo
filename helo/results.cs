namespace helo;

public class Results
{
	public int Temp {get; set;}
	public string Description {get; set;}
    public int Date {get; set;}
    public int Condition_cod {get; set;}
    public int Img_id {get; set;}
	public string Currently {get; set;}
	public string City {get; set;}
	public int Humidity {get; set;}
	public double Rain {get; set;}
	public string Sunrise {get; set;}
	public string Sunset {get; set;}
	public string Wind_Speedy {get; set;}
	public int Wind_Direction {get; set;}

		return builder.Build();
	}