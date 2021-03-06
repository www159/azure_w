namespace azure_m.Models
{
    namespace ResponseModels
    {

        public class ListVirtualMachineResponse : ListResponse<VirtualMachine> { }

        public class VirtualMachineResponse : VirtualMachine { }

        public class VMSizeProperties
        {

            public int? vCPUsAvailable { get; set; }

            public int? vCPUsPerCore { get; set; }
        }
        public class HardwareProfile
        {
            public string vmSize { get; set; }

            public VMSizeProperties vmSizeProperties { get; set; }

        }




        public class DeleteOptions
        {

            public static string Delete = "Delete";

            public static string Detach = "Detach";
        }


        public class NetworkProfile
        {

            public NetworkInterface[] networkInterfaces { get; set; }

            /*

            public NetworkApiVersion networkApiVersion { get; set; }

            public List<VitualMachineNetworkInterfaceCOnfiguration> networkInterfaceConfigurations { get; set; }

            */
        }


        public class OSProfile
        {

            /*

            最小长度 (Windows) ：8 个字符

            Linux) 最小长度 (： 6 个字符

            最大长度 (Windows) ：123 个字符

            Linux) 最大长度 (： 72 个字符

            复杂性要求： 需要满足以下 4 个条件中的 3 个
            字符较低
            具有大写字符
            包含数字
            具有特殊字符 (正则表达式匹配 [\W_])

            不允许的值： “abc@123”、“P@$$w 0rd”、“P@ssw0rd”、“P@ssword123”、“Pa$$word”、“pass@word1”、“Password！”、“Password1”、“Password22”、“iloveyou！”

            若要重置密码，请参阅如何在 Windows VM 中重置远程桌面服务或其登录密码

            */
            public string adminPassword { get; set; }

            /*
            创建 VM 后，无法更新此属性。

            仅Windows限制：不能以“结尾”。

            不允许的值： “administrator”、“admin”、“user”、“user1”、“test”、“user2”、“test1”、“user1”、“user3”、“admin1”、“1”， “123”、“a”、“actuser”、“adm”、“admin2”、“aspnet”、“backup”、“console”、“david”、“guest”、“john”、“owner”、“root”、“server”、“sql”、“support”、“support_388945a0”、“sys”、“test2”、“test3”、“user4”、“user5”。

            Linux) 最小长度 (： 1 个字符

            Linux) 的最大长度 (： 64 个字符

            最大长度 (Windows) ：20 个字符。
            */
            public string adminUsername { get; set; }

            public bool? allowExtensionOperations { get; set; }

            public string computerName { get; set; }

            public string customData { get; set; }

            public bool? requireGuestProvisionSignal { get; set; }

            /*

            public LinuxConfiguration linuxConfiguration { get; set; }

            public List<VailtSecretGroup> secrets { get; set; }

            public WindowsConfiguration windowsConfiguration { get; set; }

            */

        }


        public class CachingTypes
        {

            public static string None = null;

            public static string ReadOnly = "ReadOnly";

            public static string ReadWrite = "ReadWrite";

        }

        public class DiskCreateOptionTypes
        {

            public static string Attach = "Attach";

            public static string Empty = "Enmpty";

            public static string FromImage = "FromImage";

        }

        public class DiskDeleteOptionTypes : DeleteOptions { }

        public class DiffDiskPlacement
        {

            public static string CacheDisk = "CacheDisk";

            public static string ResourceDisk = "ResourceDisk";

        }

        public class DiffDiskOptions
        {

            public static string Local = "Local";
        }

        public class DiffDiskSettings
        {

            // Type:  DiffDIskOptions
            // Value: CacheDisk, ResourceDisk
            public string placement { get; set; }

            // Type:  DiffDiskOptions
            // Value: Local
            public string options { get; set; }
        }

        public class DiskEncryptionSetParameters
        {

            public string id { get; set; }

        }

        public class SecurityEncrytionTypes
        {

            public string DiskWithVMGuestState = "DiskWithVMGuestState";

            public string VMGuestStateOnly = "VMGuestStateOnly";

        }

        public class VMDiskSecurityProfile
        {

            public DiskEncryptionSetParameters diskEncryptionSet { get; set; }

            // Type:  SecurityENcrytionTypes
            // Value DiskWithVMGuestState, VMGuestStateOnly
            public string securityEncryptionType { get; set; }

        }

        public class StorageAccountTypes
        {

            public static string PRemiumV2_LRS = "PRemiumV2_LRS";

            public static string Premium_LRS = "Premium_LRS";

            public static string Premium_ZRS = "Premium_ZRS";

            public static string StandardSSD_LRS = "StandardSSD_LRS";

            public static string StandardSSD_ZRS = "StandardSSD_ZRS";

            public static string Standard_LRS = "Standard_LRS";

            public static string UltraSSD_LRS = "UltraSSD_LRS";

        }
        public class ManagedDiskParameters
        {

            public DiskEncryptionSetParameters diskEncryptionSet { get; set; }

            public string id { get; set; }

            public VMDiskSecurityProfile securityProfile { get; set; }

            // Type:  StorageAccountTypes
            // Value: ...
            public string storageAccountType { get; set; }
        }

        public class OperatingSystemTypes
        {

            public static string Linux = "Linux";

            public static string Windows = "Windows";
        }

        public class VirtualHardDisk
        {

            public string uri { get; set; }
        }
        public class Disk
        {

            // Type:  CachingTypes
            // Value: None, ReadOnly, ReadWrite
            public string caching { get; set; }

            // Type:  DiskCreateOptionTypes
            // Value: Attach, Empty, FromImage
            public string createOption { get; set; }

            // Type:  DiskDeleteOptionTypes
            // Value: Delete, Detach
            public string deleteOption { get; set; }

            public int? diskSizeGB { get; set; }

            /*

            public VirtualHardDisk image { get; set; }

            */

            public ManagedDiskParameters managedDisk { get; set; }

            public string name { get; set; }



            public VirtualHardDisk vhd { get; set; }

            public bool? writeAcceleratorEnabled { get; set; }

        }

        public class OSDisk : Disk
        {

            // Type:  OperatingSystemTypes
            // Value: Linux, Windows
            public string osType { get; set; }

            /*

            public DiskEncryptionSettings encryptionSettings

            */
        }

        public class DiskDetachOptionTypes
        {

            public static string ForceDetach = "ForceDetach";
        }

        public class DataDisk : Disk
        {

            // Type:  DiskDetachOptionTypes
            // Value: ForceDetach
            public string detachOption { get; set; }

            public int? diskIOSReadWrtite { get; set; }

            public int? diskMBpsReadWrite { get; set; }

            public int? lun { get; set; }

            public bool? toBeDetach { get; set; }
        }

        public class ImageReference
        {

            public string communityGalleryImageId { get; set; }

            public string exactVersion { get; set; }

            public string offer { get; set; }

            public string publisher { get; set; }

            public string sharedGalleryImageId { get; set; }

            public string sku { get; set; }

            public string version { get; set; }

            public override string ToString()
            {
                return offer + sku;
            }
        }

        public class StorageProfile
        {

            public DataDisk[] dataDisks { get; set; }

            public OSDisk oSDisk { get; set; }

            public ImageReference imageReference { get; set; }
        }


        public class VirtualMachineProperties
        {
            public HardwareProfile hardwareProfile { get; set; }

            public NetworkProfile networkProfile { get; set; }

            public OSProfile osProfile { get; set; }

            public StorageProfile storageProfile { get; set; }

            /*

            public AdditionalCapabilities addtionalCapabilities { get; set; }

            public ApplicationProfile applicationProfile { get; set; }

            public SubResource availabilitySet { get; set; }

            public BillingProfile billingProfile { get; set; }

            public CapacityReservationProfile capacityReservation { get; set; }

            public DiagnosticsProfile diagnosticProfile { get; set; }

            public VirtualMachineEvictionPolicyTypes evictionPolicy { get; set; }

            public string extensionsTumeBuget { get; set; }

            public SubResource host { get; set; }

            public string licenseType { get; set; }

            public int? platformFaultDomain { get; set; };

            public VirtualMachinePrioityTypes priority { get; set; }

            public SubResource proximityPlacementGroup { get; set; }

            public SecurityProfile securityProfile { get; set; }

            public string userData { get; set; }

            public SubResource virtualMachineScaleSet { get; set; }

            */

        }


        public class VirtualMachine
        {
            public string location { get; set; }

            /*

            public ExtendedLocation extendedLocation { get; set; }

            public VirtualMachineIdentity identity { get; set; }

            public Plan plan { get; set; }

            */

            public VirtualMachineProperties properties { get; set; }

            public object tags { get; set; }

            public string[] zones { get; set; }

            public string name { get; set; }

            public string id { get; set; }

        }
    }
}
