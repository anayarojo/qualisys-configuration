## Qualisys Configuration
Utility to obtain configurations in a specific data type.

#### Nuget installation:

```
Install-Package QualisysConfig -Version 1.0.3
```

#### Configuration example:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <connectionStrings>
    <add name="Connection" connectionString=""/>
  </connectionStrings>
  <appSettings>
    <add key="string" value="string"></add>
    <add key="char" value="c"></add>
    <add key="int" value="1"></add>
    <add key="long" value="123456789"></add>
    <add key="float" value="1.5"></add>
    <add key="double" value="1.5"></add>
    <add key="decimal" value="1.5"></add>
    <add key="date" value="13/12/2017"></add>
    <add key="bool" value="True"></add>
    <add key="enum" value="ENUM_A"></add>
  </appSettings>
</configuration>
```

#### Basic use example:

```csharp
using System;
using QualisysConfig;

public class Program
{
	public static void Main()
	{
            string lStrValue = QsConfig.GetValue<string>("string");
            char lChrValue = QsConfig.GetValue<char>("char");
            int lIntValue = QsConfig.GetValue<int>("int");
            long lLonValue = QsConfig.GetValue<long>("long");
            float lFltValue = QsConfig.GetValue<float>("float");
            double lFltValue = QsConfig.GetValue<double>("double");
            decimal lDmlValue = QsConfig.GetValue<decimal>("decimal");
            DateTime lDtmValue = QsConfig.GetValue<DateTime>("date");
            bool lBolValue = QsConfig.GetValue<bool>("bool");
            SampleEnum lEnmValue = QsConfig.GetValue<SampleEnum>("enum");
	}
}

public enum SampleEnum
{
    ENUM_A,
    ENUM_B,
    ENUM_C
}
```

See more

[Nuget package page](https://www.nuget.org/packages/QualisysConfig/)
