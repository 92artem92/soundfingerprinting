﻿namespace SoundFingerprinting.MongoDb.Tests.Integration
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SoundFingerprinting.DAO;
    using SoundFingerprinting.Tests.Integration.Dao;

    [TestClass]
    public class HashBinDaoTest : AbstractHashBinDaoTest
    {
        public HashBinDaoTest()
        {
            HashBinDao = new HashBinDao();
            TrackDao = new TrackDao();
            SubFingerprintDao = new SubFingerprintDao();
        }

        public override sealed IHashBinDao HashBinDao { get; set; }

        public override sealed ITrackDao TrackDao { get; set; }

        public override sealed ISubFingerprintDao SubFingerprintDao { get; set; }
    }
}