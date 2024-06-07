﻿using SQLite;

namespace MeuAppPods
{
    public static class Constants
    {
        private const string DBFileName = "Dados.db3";

        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                return Path
                    .Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
