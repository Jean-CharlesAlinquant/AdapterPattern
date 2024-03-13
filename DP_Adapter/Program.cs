using DesignPatterns.Adapter;

String someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

//IXmlParser<Note> parser = new XmlParser<Note>();
IJsonParser<Note> parser = new XmlToJsonAdapter<Note>();
Note? note = parser.Parse(someXml);
//Console.WriteLine(parser.ConvertToXml(note));
if (note is not null)
{
    Console.WriteLine(parser.ConvertToJson(note));
}
