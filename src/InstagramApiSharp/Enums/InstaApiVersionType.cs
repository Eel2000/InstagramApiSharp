﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ RamtinJokar@outlook.com ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

namespace InstagramApiSharp.Enums
{
    public enum InstaApiVersionType
    {
        /// <summary>
        ///     Default api version. v44.0.0.9.93 => No more consent required error.
        /// </summary>
        Version44 = 0,
        /// <summary>
        ///     Api version => No more consent required error.
        /// </summary>
        Version35 = 1,
        /// <summary>
        ///     Api version 61.0.0.19.86 => All data like signature key, version code and ... is for v44 except instagram version
        /// </summary>
        Version61 = 2,
        /// <summary>
        ///     Api version 64.0.0.14.96
        /// </summary>
        Version64 = 3,
        /// <summary>
        ///     Api version 74.0.0.21.99 => All data like signature key, version code and ... is for v64 except instagram version
        /// </summary>
        Version74 = 4,
        /// <summary>
        ///     Api version 76.0.0.15.395
        /// </summary>
        Version76 = 5,
        /// <summary>
        ///     Api version 86.0.0.24.87
        /// </summary>
        Version86 = 6,
        /// <summary>
        ///     Api version 107.0.0.27.121
        /// </summary>
        Version107 = 7,
        /// <summary>
        ///     Api version 126.0.0.25.121
        /// </summary>
        Version126 = 22,
        /// <summary>
        ///     Api version 180.0.0.31.119, Requires BouncyCastle Nuget Package!!! 
        /// </summary>
        Version180 = 30,
    }
}
