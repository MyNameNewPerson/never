using System.Collections.Generic;

namespace ABClient.Lez;

public static class LezBotsClassCollection
{
	private static readonly SortedDictionary<int, LezBotsClass> sortedDictionary_0;

	static LezBotsClassCollection()
	{
		sortedDictionary_0 = new SortedDictionary<int, LezBotsClass>();
		smethod_0(new LezBotsClass(1, "Все", "Все"));
		smethod_0(new LezBotsClass(10, "Человек", "Люди"));
		smethod_0(new LezBotsClass(20, "Бот", "Боты"));
		smethod_0(new LezBotsClass(21, "Босс", "Боссы"));
		smethod_0(new LezBotsClass(101, "Орк", "Орки"));
		smethod_0(new LezBotsClass(102, "Гоблин", "Гоблины"));
		smethod_0(new LezBotsClass(103, "Крыса", "Крысы"));
		smethod_0(new LezBotsClass(104, "Кабан", "Кабаны"));
		smethod_0(new LezBotsClass(105, "Ядовитый паук", "Ядовитые пауки"));
		smethod_0(new LezBotsClass(106, "Скелет", "Скелеты"));
		smethod_0(new LezBotsClass(107, "Скелет-мечник", "Скелеты-мечники"));
		smethod_0(new LezBotsClass(108, "Зомби", "Зомби"));
		smethod_0(new LezBotsClass(109, "Тролль", "Тролли"));
		smethod_0(new LezBotsClass(110, "Огр", "Огры"));
		smethod_0(new LezBotsClass(111, "Огр-берсеркер", "Огры-берсеркеры"));
		smethod_0(new LezBotsClass(126, "Огр-защитник", "Огры-защитники"));
		smethod_0(new LezBotsClass(112, "Сильф", "Сильфы"));
		smethod_0(new LezBotsClass(113, "Нетопырь", "Нетопыри"));
		smethod_0(new LezBotsClass(114, "Разбойник", "Разбойники"));
		smethod_0(new LezBotsClass(115, "Грабитель", "Грабители"));
		smethod_0(new LezBotsClass(116, "Призрак", "Призраки"));
		smethod_0(new LezBotsClass(117, "Некромант", "Некроманты"));
		smethod_0(new LezBotsClass(118, "Элементаль", "Элементали"));
		smethod_0(new LezBotsClass(119, "Дварф", "Дварфы"));
		smethod_0(new LezBotsClass(120, "Медведь", "Медведи"));
		smethod_0(new LezBotsClass(121, "Воин Таэров", "Воины Таэров"));
		smethod_0(new LezBotsClass(122, "Лич", "Личи"));
		smethod_0(new LezBotsClass(125, "Архилич", "Архиличи"));
		smethod_0(new LezBotsClass(123, "Чумной зомби", "Чумные зомби"));
		smethod_0(new LezBotsClass(124, "Паладин Мортиуса", "Паладины Мортиуса"));
		smethod_0(new LezBotsClass(127, "Архипаладин Мортиуса", "Архипаладины Мортиуса"));
	}

	private static void smethod_0(LezBotsClass lezBotsClass_0)
	{
		if (!sortedDictionary_0.ContainsKey(lezBotsClass_0.Id))
		{
			sortedDictionary_0.Add(lezBotsClass_0.Id, lezBotsClass_0);
		}
	}

	public static LezBotsClass GetClass(int id)
	{
		if (!sortedDictionary_0.ContainsKey(id))
		{
			return new LezBotsClass(0, id.ToString(), id.ToString());
		}
		return sortedDictionary_0[id];
	}

	public static List<LezBotsClass> ListForComboBox()
	{
		return new List<LezBotsClass>(sortedDictionary_0.Values);
	}
}
