global using CommandDotNet;
global using Spectre.Console;
global using Newtonsoft.Json;
global using RestSharp;
global using console_entity_framwork_core.Commands;
global using console_entity_framwork_core.Models;
global using System.Net.Http;
global using System.Text;

var app = (dynamic? param)=>{
    if(param != null)
        param.Run(args);
};

var runner = new AppRunner<Spotity>();

app(runner);