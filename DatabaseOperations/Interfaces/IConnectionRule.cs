﻿namespace DatabaseOperations.Interfaces
{
    using DataTransferObjects;

    internal interface IConnectionRule
    {
        bool Check(string item);

        ConnectionOptions ApplyChange(
            ConnectionOptions options,
            string item);
    }
}