# RedisWithCSharp

RedisWithCSharp is a template project that allows you to use Redis cache within .NET.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites
* Redis Service

### Installing Redis Service
To run Redis as a service;
* Extract redis-2.4.6-setup-64-bit.rar under External folder
* Run redis-2.4.6-setup-64-bit.exe

Change configuration to access Redis service from application: 
* Change ConfigSections under App.Config file at project RedisWithCSharp.UnitTests:
```csharp
  <configSections>
    <section name="RedisConfiguration" type="XXX.RedisConfigurationSection, XXX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"/>
  </configSections>
  <RedisConfiguration host="YOURHOSTNAME" port="YOURPORT"/>
```

**NOTE**: Status of Redis service have to be **'Running'** under **Task Manager -> Services**.

## Authors

* **Ilker Yaman** - *Initial work* - [RedisWithCSharp](https://github.com/ilkeryaman/RedisWithCSharp)

## More
You can read more about Redis at https://redis.io/ .
