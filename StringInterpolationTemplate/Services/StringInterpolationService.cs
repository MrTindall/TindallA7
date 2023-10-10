using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        // IMPORTANT, YOU HAVE TO USE THIS _date
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        return answer;

    }

    public string Number03()
    {
        var date = _date.Now.ToString("'Day' dd 'of' MMMM, yyyy");
        var answer = $"{date}";
        return answer;
    }

    public string Number04()
    {
        var date = _date.Now.ToString("Year: yyyy 'Month:' MM, 'Day:' dd");
        var answer = $"{date}";
        return answer;
    }

    public string Number05()
    {
        var date = _date.Now.ToString($"dddd");
        var answer = $"{date,10}";
        return answer;
    }

    public string Number06()
    {
        var answer = _date.Now.ToString($"{_date.Now,4:hh}:{_date.Now:mm} tt {_date.Now,6:'dddd'}");
        return answer;
    }

    public string Number07()
    {
        var answer = _date.Now.ToString($"'h':{_date.Now,10:hh}, 'm':{_date.Now:mm}, 's':{_date.Now:ss}");
        return answer;
    }

    public string Number08()
    {
        var answer = _date.Now.ToString($"{_date.Now:yyyy.MM.dd.hh.mm.ss}");
        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = _date.Now.ToString($"{pi:C}");
        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = _date.Now.ToString($"{pi,10:F3}");
        return answer;
    }

    public string Number11()
    {
        var answer = _date.Now.ToString($"{_date.Now:yyyy}");
        string hexadecimalYear = int.Parse(answer).ToString("X").ToUpper();
        return hexadecimalYear;
    }

    
}
