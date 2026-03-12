using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;

namespace ABClient;

public static class ChatUsersManager
{
	private static readonly SortedDictionary<string, ChatUser> sortedDictionary_0 = new SortedDictionary<string, ChatUser>();

	private static readonly ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	public static bool Exists(string userNick)
	{
		if (sortedDictionary_0.ContainsKey(userNick.ToLower()))
		{
			return true;
		}
		string[] array = Class12.smethod_1(Class21.smethod_3(Class21.smethod_2(userNick)), "\n3|", "\n4|").Split('|');
		string text = array[0];
		string level = array[1];
		string sign = array[4];
		string status = array[5];
		ChatUser value = new ChatUser(text, level, sign, status);
		sortedDictionary_0.Add(text.ToLower(), value);
		return true;
	}

	public static ChatUser GetUserData(string userNick)
	{
		if (!sortedDictionary_0.TryGetValue(userNick.ToLower(), out var value))
		{
			return null;
		}
		return value;
	}

	public static void AddUser(ChatUser chatUser)
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				if (sortedDictionary_0.TryGetValue(chatUser.Nick.ToLower(), out var _))
				{
					sortedDictionary_0[chatUser.Nick.ToLower()] = chatUser;
				}
				else
				{
					sortedDictionary_0.Add(chatUser.Nick.ToLower(), chatUser);
				}
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	public static void Save()
	{
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				XmlWriterSettings settings = new XmlWriterSettings
				{
					Indent = true
				};
				MemoryStream memoryStream = new MemoryStream();
				XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings);
				xmlWriter.WriteStartDocument();
				xmlWriter.WriteStartElement("chatusers");
				foreach (KeyValuePair<string, ChatUser> item in sortedDictionary_0)
				{
					xmlWriter.WriteStartElement("user");
					xmlWriter.WriteStartAttribute("nick");
					xmlWriter.WriteString(item.Value.Nick ?? string.Empty);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("sign");
					xmlWriter.WriteString(item.Value.Sign ?? string.Empty);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("status");
					xmlWriter.WriteString(item.Value.Status ?? string.Empty);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("level");
					xmlWriter.WriteString(item.Value.Level ?? string.Empty);
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteStartAttribute("lastupdated");
					xmlWriter.WriteString(item.Value.LastUpdated.ToString(CultureInfo.InvariantCulture));
					xmlWriter.WriteEndAttribute();
					xmlWriter.WriteEndElement();
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndDocument();
				xmlWriter.Flush();
				try
				{
					FileStream fileStream = new FileStream("chatusers_new.xml", FileMode.Create);
					memoryStream.WriteTo(fileStream);
					fileStream.Close();
					memoryStream.Close();
					if (File.Exists("chatusers.xml"))
					{
						File.Delete("chatusers.xml");
					}
					File.Move("chatusers_new.xml", "chatusers.xml");
				}
				catch (IOException)
				{
				}
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}

	internal static void smethod_0()
	{
		if (!File.Exists("chatusers.xml"))
		{
			return;
		}
		try
		{
			readerWriterLock_0.AcquireWriterLock(5000);
			try
			{
				string xml;
				try
				{
					xml = File.ReadAllText("chatusers.xml", Encoding.UTF8);
				}
				catch
				{
					return;
				}
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				foreach (XmlNode item in xmlDocument.GetElementsByTagName("user"))
				{
					if (item.Attributes != null)
					{
						DateTime value = Convert.ToDateTime(item.Attributes["lastupdated"].Value, CultureInfo.InvariantCulture);
						if (!(DateTime.Now.Subtract(value).TotalDays > 1.0))
						{
							string value2 = item.Attributes["nick"].Value;
							string value3 = item.Attributes["level"].Value;
							string value4 = item.Attributes["sign"].Value;
							string value5 = item.Attributes["status"].Value;
							ChatUser value6 = new ChatUser(value2, value3, value4, value5);
							sortedDictionary_0.Add(value2.ToLower(), value6);
						}
					}
				}
			}
			finally
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
		catch (ApplicationException)
		{
		}
	}
}
