using System;

namespace Game
{
    class Program
	{
		static int roomNumber = 1;
		static bool hasKey = false;
		static bool hasPrincess = false;

		static void Main(string[] args)
		{
			Introduction();

			while (true)
			{
				if (roomNumber == 1) ActionStarship(); //крепость
				else if (roomNumber == 2) ActionTemple();
				else if (roomNumber == 3) ActionLivingRoom();
				else if (roomNumber == 4) ActionDangerRoom();
				else if (roomNumber == 5) ActionQuestRoom();
				else if (roomNumber == 6) ActionOtherShip();

			}
		}

		static void ActionStarship()
		{
			Console.Clear();
			
			
            Console.WriteLine("В переулке стояли Миньоны и Джейс.");
			Console.WriteLine("Джейс отдаёт листок и говорит, что будет ждать здесь нас.");
            Console.WriteLine("Ты выходишь с переулка, достаёшь письмо и наблюдаешь:");
            Console.WriteLine("==================================================");
			Console.WriteLine("Неделю назад был взрыв и украден Хекстек...");
            Console.WriteLine("Взрыв был сильным и разнес всю комнату с Хекстеком.");
			Console.WriteLine("Говорят, Хекстек взяли люди из Зауна и один из них был с синими волосами.");
            Console.WriteLine("Охрана говорит, что Хекстек взорвался с комнатой, но я им не верю....");
            Console.WriteLine("Твоя задача: ОТПРАВИТЬСЯ В ЗАУН И ВЕРНУТЬ ХЕКСТЕК!!!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("*В Зауне будьте осторожны!Там гуляет всякая нечесть,которая зависит от Мерцания");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Хекстек очень важен для Пилтовера!");
            Console.WriteLine("==================================================");
            Console.WriteLine("Доступные действия:");
			Console.WriteLine("1.Отправиться в Заун");
			int option;
			if (hasPrincess)
			{
				Console.WriteLine("2.Отдать Хекстек");
				option = GetIntInRange(2);
			}
			else option = GetIntInRange(1);

			if (option == 1)
			{
				Console.WriteLine("Ты отправляешься в Заун...");
				roomNumber = 2;
			}
			else if(option == 2)
			{
				Conclusion();
				
			}



		}

		static void ActionTemple() 
		{
			Console.Clear();
			Console.WriteLine("В Зауне находишь бар и заходишь в него.");
            Console.WriteLine("Ты идешь к барной стойке, заказываешь напиток и спрашиваешь у бармена про взрыв...");
            Console.WriteLine("==============================================");
			Console.WriteLine("-Ты я вижу не из наших краёв.Сказав такое...");
			Console.WriteLine("*Ты платишь ему 200 золотых монет");
			Console.WriteLine("-Взрыв произошел из-за ошибки Паудер.Это полоумная девица с целым арсеналом смертоносного оружия, превратилась в безбашенную Джинкс.");
			Console.WriteLine("-Джинкс это девушка с синими волосами?");
			Console.WriteLine("-Конечно...Джинкс ураганом ворвалась в Пилтовер, о ее уникальном таланте сеять хаос стали ходить слухи.");
			Console.WriteLine("-Ты знаешь, где её можно найти?");
			Console.WriteLine("-Она постоянно ошивается около Силко, больше ничего не скажу...");
			Console.WriteLine("==============================================");
			Console.WriteLine("Доступные действия:");

			Console.WriteLine("1.Пойти обратно в Пилтовер");
			Console.WriteLine("2.Отправиться в рядом заброшенное здание");
			Console.WriteLine("3.Отправиться поискать её рядом с логовом");
			int option = GetIntInRange(3);

			if (option == 1)
			{
				Console.WriteLine("Уходишь обратно в Пилтовер...");
				roomNumber = 1;
				Console.ReadLine();
			}
			else if (option == 2)
			{
				Console.WriteLine("Ты идешь к заброшенному зданию...");
				roomNumber = 3;
				Console.ReadLine();

			}
			else
			{
				OpenOldDoor();
			}
		}

		static void OpenOldDoor()
		{
			Console.WriteLine("Ты приходишь в логово Силко.");
			Console.WriteLine("Тебе повезло, что тебя не заметила охрана, но ты стоишь рядом с обрывом...");
            Console.WriteLine("Тебе нужно перейти на другую сторону, но ты не видишь моста или какой-нибудь лестницы...");
            Console.WriteLine("Конечно можно прыгнуть в пропасть, но лучше этого не делать...");
			if (!hasKey)
			{
				Console.WriteLine("============================================");
				Console.WriteLine("Тебе нужна лестница!");
				Console.WriteLine("============================================");
			}
			else
			{
				Console.WriteLine("Взяв в руки лестницу, ты пытаешься пройти по ней через обрыв.");
				Console.WriteLine("Ты встаешь на лестницу, доходишь до середины...");
				Console.WriteLine("Лестница еле-еле выдерживает тебя, но ты проходишь дальше...");
				roomNumber = 4;

			}
			Console.ReadLine();

		}

		static void ActionLivingRoom()
		{
		
			Console.Clear();
			Console.WriteLine("Ты зашёл внутрь этого здания.Зажег факел и смотришь по сторонам");
			Console.WriteLine("Вокруг было много хлама...*Пчихнул(а) ");
			Console.WriteLine("И очень пыльно...");
			int option;
			Console.WriteLine("Доступные действия:");
			Console.WriteLine("1.Вернуться обратно"	);
			if (!hasKey)
			{
				Console.WriteLine("2.Поискать в хламе лестницу");
				option = GetIntInRange(2);
			}
			else option = GetIntInRange(1);

			if (option == 1)
			{
				Console.WriteLine("Возвращаешься обратно...");
				roomNumber = 2;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("В большой кучке хлама ты находишь лестницу!");
				Console.WriteLine("Теперь можно вернуться к обрыву!");
				hasKey = true;
				Console.ReadLine();
			}
		}
		static void ActionDangerRoom()
		{
			Console.Clear();
            Console.WriteLine("После преодоления обрыва, ты проходишь дальше и видишь стол с инструментами.");
            Console.WriteLine("Ты подходишь к нему и видишь штуку похожую на игрушку");
			Console.WriteLine("*Игрушка издаёт странные звуки...");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1.Вернуться обратно");
            Console.WriteLine("2.Идти дальше");
            Console.WriteLine("3.Взять в руки игрушку");
			int option = GetIntInRange(3);

			if (option == 1)
			{
				Console.WriteLine("Возвращаемся обратно...");
				roomNumber = 2;
				Console.ReadLine();
			}
			else if (option == 2)
			{
				Console.WriteLine("Ты подумал, что ничего интересного и пошел дальше...");
				roomNumber = 5;
				Console.ReadLine();

			}
			else Death();
		
		}

		static void Death()
        {
            Console.WriteLine("Ты берешь в руку игрушку и она резко начинает дрожать.");
            Console.WriteLine("Ты пытаешься её удержать на руках...");
			Console.WriteLine("Но у тебя не получается и она взрывается!");
			Console.WriteLine("*Это была граната собственного производства Джинкс...");
			Console.WriteLine("===============");
			Console.WriteLine("Ты умер.");
			Console.WriteLine("---------------");
			Console.ReadLine();
			Environment.Exit(0);
        }
		static void ActionQuestRoom()
		{
			Console.Clear();
            Console.WriteLine("Пройдя дальше ты натыкаешься на дом ...");
			Console.WriteLine("Дом на вид был странным и разрушенным... ");
			Console.WriteLine("Ты подходишь к двери и видишь электронный замок.");
			Console.WriteLine("Доступные действия:");
			Console.WriteLine("1.Вернуться обратно");
			Console.WriteLine("2.Попытаться взломать его");
			int option = GetIntInRange(2);

			if (option == 1)
			{
				Console.WriteLine("С весёлым настроением топаешь обратно...");
				roomNumber = 4;
				Console.ReadLine();
			}
			else CompleteQuest();
		}

		static void CompleteQuest()
        {
			Console.Clear();
			Console.WriteLine("Ты пытаешься его взломать, и вдруг появилась голография Джинкс: ");
            Console.WriteLine("=================================================");
			Console.WriteLine("Чтоб зайти в дом ты должен разгадать мою загадку!");
			Console.WriteLine("Загадка:");
            Console.WriteLine("Есть два стула!Один с надписью Джинкс, другой Паудер.На какой мне сесть?");
            Console.WriteLine("==================================================");
            Console.WriteLine("*Напишите Джинкс или Паудер");
            string answer = Console.ReadLine();

			while (answer.ToLower() != "Джинкс")
            {
                Console.WriteLine("Ты ввёл неправильное действие,попробуй ещё раз:");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Дом открылся, ты хорошо разбираешься в стульях...");
			roomNumber = 6;
			Console.ReadLine();
		}


		static void ActionOtherShip()
		{
			Console.Clear();
            Console.WriteLine("Зайдя внутрь ты видишь странную тень...");
			Console.WriteLine("В комнату, в которую ты вошел чем-то напоминает детскую");
			Console.WriteLine("Вдруг тень воспылала красочным огнём...");
			Console.WriteLine("Ты присматриваешься и видишь, что это Джинкс с её пушкой!");
            Console.WriteLine("*У тебя нет оружия...");
			int option;
			Console.WriteLine("Доступные действия:");
			Console.WriteLine("1.Выйти наружу");
			if (!hasPrincess)
			{
				Console.WriteLine("2.Побегать от пуль");
				option = GetIntInRange(2);
			}
			else option = GetIntInRange(1);

			ChooseOptionsInOtherShip(option);
		}

		static void ChooseOptionsInOtherShip(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Ты незаметно выходишь наружу...");
				roomNumber = 5;
				Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Ты бегаешь от неё как Молния Маккуин.");
				Console.WriteLine("Бегая по комнате с криками, ты натыкаешься на синий шарик!");
				Console.WriteLine("Это оказывается был Хекстек");
				Console.WriteLine("Ты его подбираешь и уходишь в дым от пуль...");
				hasPrincess = true;
				Console.ReadLine(); 
			}
		}

		static void Introduction()
		{
			Console.WriteLine("Просторная уютная кухня.Никого нет, только у пылающего камина греется кот.");
			Console.WriteLine("В дом заходит неизвестный чемпион.Он подходит к порталу и отправляется в другой мир...");
			Console.WriteLine("Введите имя своего чемпиона:");
			string namePerson  = Console.ReadLine();
            Console.WriteLine($"Его звали {namePerson}.");
            Console.WriteLine("За этого чемпиона ты будешь играть!");
			Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Ты очутился в каком-то доме и тебе захотелось лечь на кровать.");
            Console.WriteLine("Через несколько часов к тебе постучались в дверь... ");
            Console.WriteLine("Ты подошел к ней и открыл её...Это были Миньоны трона.");
            Console.WriteLine("Тебе они вручили письмо со штампом и ушли.");
            Console.WriteLine("Ты медленно открываешь письмо и внимательно читаешь.");
			Console.WriteLine("======================================================================================");
            Console.WriteLine("*Приказ правительства Пилтовера.");
            Console.WriteLine("В 0:00 прийти к воротам Пилтовера и не опаздывать.");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Ты взял печеньку, закрыл дверь дома и вышел на улицу.");
            Console.WriteLine("Подойдя к воротам, ты никого не увидел...Прошло 10 минут...К тебе подходит незнакомый и говорит следовать за ним.");
            Console.WriteLine("Пройдя несколько кварталов, тебя заводят в переулок...");
            Console.ReadLine();
		}

		static void Conclusion()
		{
			Console.WriteLine("Ты отдал Хекстек Джейсу и отправился домой спать!");
			Console.WriteLine("Конец игры");
			Console.ReadLine();
			Environment.Exit(0);
		}

		static int GetIntInRange(int optionsNumber)
		{
			string input = Console.ReadLine();
			int number = -1;
			bool isConverted = int.TryParse(input, out number);
			bool isInRange = number >= 1 && number <= optionsNumber;

			while (!isConverted || !isInRange)
			{
				Console.WriteLine("Неверная опция, попробуйте ещё раз");
				input = Console.ReadLine();
				isConverted = int.TryParse(input, out number);
				isInRange = number >= 1 && number <= optionsNumber;


			}
			return number;
		}
	}
}
