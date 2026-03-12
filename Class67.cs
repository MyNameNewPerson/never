internal sealed class Class67
{
	internal string string_0;

	internal string string_1;

	internal float float_0;

	internal float float_1;

	internal bool bool_0;

	internal string string_2;

	internal string string_3;

	internal Class67(string string_4)
	{
		string[] array = string_4.Split('|');
		string_1 = array[1];
		string_0 = array[2];
		bool_0 = string_0 == string_1;
		Class27 @class = Class28.smethod_0()[array[0]];
		string_2 = @class.method_2();
		string_3 = @class.method_6();
		float_0 = (float)int.Parse(string_0) * @class.method_4();
		float_1 = (float)int.Parse(string_1) * @class.method_4();
	}
}
