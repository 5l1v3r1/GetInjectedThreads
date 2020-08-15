﻿using System.Collections.Generic;

namespace GetInjectedThreads.Yara
{
    static class YaraRules
    {

        public static string cobaltStrikeRule = "rule CobaltStrike { " +
                "strings:  " +
                    "$sprng = { 73 70 72 6E 67 00 } " +
                    "$config_v3 = { 69 68 69 68 69 6b } " +
                    "$config_v4 = { 2e 2f 2e 2f 2e 2c } " +
                "condition: " +
                    "$sprng and ($config_v3 or $config_v4)" +
            "}";

        public static List<string> meterpreterRules = new List<string>(new string[] {
                     
            "rule meterpreter { " +
                "strings:  " +
                    "$ws2 =         { 57 53 32 5f 33 32 } " +     // WS2_32
                    "$metsrv =      { 6d 65 74 73 72 76 } " +     // metsrv
                    "$c2_block =    { 00 00 e0 1d 2a 0a } " +     // Start of C2 block   
                "condition: " +
                    "2 of ($ws2, $metsrv, $c2_block)" +
            "}",

        });
    }
}
