﻿namespace ExecuteByteCodeInCSharp;

public enum PageProtection
{
    PAGE_NOACESS = 0X1,
    PAGE_READONLY = 0X2,
    PAGE_READWRITE = 0X4,
    PAGE_WRITECOPY = 0X8,
    PAGE_EXECUTE = 0X10,
    PAGE_EXECUTE_READ = 0X20,
    PAGE_EXECUTE_READWRITE = 0X40,
    PAGE_EXXECUTE_WRITECOPY = 0X80,
    PAGE_GUARD = 0X100,
    PAGE_NOCACHE = 0X200,
    PAGE_WRITECOMBINE = 0X400
}
