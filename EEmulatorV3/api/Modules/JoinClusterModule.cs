﻿using System;
using System.Collections.Generic;
using EEmulatorV3.Messages;
using Nancy;
using ProtoBuf;

namespace EEmulatorV3.Modules
{
    public class JoinClusterModule : NancyModule
    {
        public JoinClusterModule()
        {
            this.Post("/api/504", ctx =>
            {
                var args = Serializer.Deserialize<JoinClusterArgs>(this.Request.Body);
                throw new NotImplementedException($"The module {nameof(JoinClusterModule)} (/api/513) has not been implemented yet.");
            });
        }
    }

    [ProtoContract]
    public class JoinClusterArgs
    {
        [ProtoMember(1)]
        public string ClusterAccessKey { get; set; }

        [ProtoMember(2)]
        public bool IsDevelopmentServer { get; set; }

        [ProtoMember(3)]
        public List<int> Ports { get; set; }

        [ProtoMember(4)]
        public string MachineName { get; set; }

        [ProtoMember(5)]
        public string Version { get; set; }

        [ProtoMember(6)]
        public string MachineId { get; set; }

        [ProtoMember(7)]
        public string Os { get; set; }

        [ProtoMember(8)]
        public string Cpu { get; set; }

        //[ProtoMember(9)]
        //public uint CpuCores { get; set; }

        //[ProtoMember(10)]
        //public uint CpuLogicalCores { get; set; }

        //[ProtoMember(11)]
        //public uint CpuAddressWidth { get; set; }

        //[ProtoMember(12)]
        //public uint CpuMaxClockSpeed { get; set; }

        //[ProtoMember(13)]
        //public uint RamMegabytes { get; set; }

        //[ProtoMember(14)]
        //public uint RamSpeed { get; set; }
    }

    [ProtoContract]
    public class JoinClusterOutput
    {
        [ProtoMember(1)]
        public string InstanceId { get; set; }

        [ProtoMember(2)]
        public string JoinedClusterName { get; set; }

        [ProtoMember(3)]
        public uint MaxPlayersPerRoom { get; set; }

        [ProtoMember(4)]
        public uint MaxCPUWatchTime { get; set; }

        [ProtoMember(5)]
        public uint MaxRoomMB { get; set; }

        [ProtoMember(6)]
        public bool CodescanGameCode { get; set; }

        [ProtoMember(7)]
        public byte[] EncryptionKey { get; set; }

        [ProtoMember(8)]
        public List<ServerEndpoint> ValidEndpoints { get; set; }

        [ProtoMember(9)]
        public string DevelopmentServerRequiredVersion { get; set; }

        [ProtoMember(10)]
        public string DevelopmentServerLatestVersion { get; set; }

        [ProtoMember(11)]
        public string DevelopmentServerDownloadUrl { get; set; }

        [ProtoMember(12)]
        public string DevelopmentServerReleaseNotes { get; set; }

        [ProtoMember(13)]
        public List<string> APIEndpoints { get; set; }

        [ProtoMember(14)]
        public uint MaxRoomCloseAPIRequests { get; set; }

        [ProtoMember(15)]
        public string ApiServerName { get; set; }

        [ProtoMember(16)]
        public string ApiServerVersion { get; set; }

        [ProtoMember(17)]
        public string ActivityLog { get; set; }
    }
}
