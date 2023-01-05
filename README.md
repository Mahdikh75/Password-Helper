# Password-Helper

Create to Types Password for .NET

1) Pattern Password

Password ps1 = new Password()

 var ptn = ps1.Pattern("number:2,lettersLower:2,LettersUpper:4,number:2,character:1");

 Console.WriteLine(ptn); // Output : 49dqQKLC10@

----------------------
2) Random Password

Password ps2 = new Password(8);

ps2.IsNumber = true;

ps2.Character = true;

ps2.LettersLowercase = true;

ps2.LettersUppercase = true;

ps2.Special = "~|\\/*-+!@#$%^&*()"; 

Console.WriteLine(ps2.Get());  // Output : #a|+4ueF
