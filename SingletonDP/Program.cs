using SingletonDP;

var singletonEmployeelogger = SingletonLogger.intance;
singletonEmployeelogger.Log("Singleton employee added");

var singletonSalarylogger = SingletonLogger.intance;
singletonSalarylogger.Log("Singleton salary calculated");

Console.WriteLine("=================================================");

var classicEmployeelogger = new ClassicLogger();
classicEmployeelogger.Log("Classic employee added");

var classicSalarylogger = new ClassicLogger();
classicSalarylogger.Log("Clsssic salary calculated");
