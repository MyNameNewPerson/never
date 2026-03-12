using System.Collections;
using System.Text;

internal sealed class Class25
{
	private readonly ArrayList arrayList_0 = new ArrayList();

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < arrayList_0.Count; i++)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("; ");
			}
			stringBuilder.Append(((Class26)arrayList_0[i]).method_0());
			stringBuilder.Append('=');
			stringBuilder.Append(((Class26)arrayList_0[i]).method_2());
		}
		return stringBuilder.ToString();
	}

	internal void method_0(string string_0, string string_1)
	{
		Class26 @class = new Class26();
		@class.method_1(string_0);
		@class.method_3(string_1);
		Class26 value = @class;
		arrayList_0.Add(value);
	}
}
