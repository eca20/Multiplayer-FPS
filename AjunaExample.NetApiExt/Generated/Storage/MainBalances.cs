//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace AjunaExample.NetApiExt.Generated.Storage
{
    
    
    public sealed class BalancesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public BalancesStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "TotalIssuance"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "InactiveIssuance"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Account"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(AjunaExample.NetApiExt.Generated.Model.pallet_balances.types.AccountData)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Locks"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(AjunaExample.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Reserves"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Holds"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Freezes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13)));
        }
        
        /// <summary>
        /// >> TotalIssuanceParams
        ///  The total units issued in the system.
        /// </summary>
        public static string TotalIssuanceParams()
        {
            return RequestGenerator.GetStorage("Balances", "TotalIssuance", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TotalIssuanceDefault
        /// Default value as hex string
        /// </summary>
        public static string TotalIssuanceDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> TotalIssuance(CancellationToken token)
        {
            string parameters = BalancesStorage.TotalIssuanceParams();
            var result = await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> InactiveIssuanceParams
        ///  The total units of outstanding deactivated balance in the system.
        /// </summary>
        public static string InactiveIssuanceParams()
        {
            return RequestGenerator.GetStorage("Balances", "InactiveIssuance", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InactiveIssuanceDefault
        /// Default value as hex string
        /// </summary>
        public static string InactiveIssuanceDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> InactiveIssuance
        ///  The total units of outstanding deactivated balance in the system.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> InactiveIssuance(CancellationToken token)
        {
            string parameters = BalancesStorage.InactiveIssuanceParams();
            var result = await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> AccountParams
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        public static string AccountParams(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Account", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AccountDefault
        /// Default value as hex string
        /// </summary>
        public static string AccountDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000000000000000000" +
                "0000000000000000000000000000000000000000000000080";
        }
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        public async Task<AjunaExample.NetApiExt.Generated.Model.pallet_balances.types.AccountData> Account(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.AccountParams(key);
            var result = await _client.GetStorageAsync<AjunaExample.NetApiExt.Generated.Model.pallet_balances.types.AccountData>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LocksParams
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        public static string LocksParams(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Locks", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LocksDefault
        /// Default value as hex string
        /// </summary>
        public static string LocksDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        public async Task<AjunaExample.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2> Locks(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.LocksParams(key);
            var result = await _client.GetStorageAsync<AjunaExample.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ReservesParams
        ///  Named reserves on some account balances.
        /// </summary>
        public static string ReservesParams(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Reserves", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReservesDefault
        /// Default value as hex string
        /// </summary>
        public static string ReservesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        public async Task<AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12> Reserves(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.ReservesParams(key);
            var result = await _client.GetStorageAsync<AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> HoldsParams
        ///  Holds on account balances.
        /// </summary>
        public static string HoldsParams(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Holds", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HoldsDefault
        /// Default value as hex string
        /// </summary>
        public static string HoldsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Holds
        ///  Holds on account balances.
        /// </summary>
        public async Task<AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13> Holds(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.HoldsParams(key);
            var result = await _client.GetStorageAsync<AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> FreezesParams
        ///  Freeze locks on account balances.
        /// </summary>
        public static string FreezesParams(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Freezes", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> FreezesDefault
        /// Default value as hex string
        /// </summary>
        public static string FreezesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Freezes
        ///  Freeze locks on account balances.
        /// </summary>
        public async Task<AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13> Freezes(AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.FreezesParams(key);
            var result = await _client.GetStorageAsync<AjunaExample.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13>(parameters, token);
            return result;
        }
    }
    
    public sealed class BalancesCalls
    {
        
        /// <summary>
        /// >> transfer_allow_death
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferAllowDeath(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 0, "transfer_allow_death", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_balance_deprecated
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetBalanceDeprecated(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> new_free, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> old_reserved)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(new_free.Encode());
            byteArray.AddRange(old_reserved.Encode());
            return new Method(4, "Balances", 1, "set_balance_deprecated", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_transfer
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceTransfer(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress source, AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(source.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 2, "force_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_keep_alive
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferKeepAlive(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 3, "transfer_keep_alive", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_all
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferAll(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Primitive.Bool keep_alive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(keep_alive.Encode());
            return new Method(4, "Balances", 4, "transfer_all", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_unreserve
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceUnreserve(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(4, "Balances", 5, "force_unreserve", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> upgrade_accounts
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UpgradeAccounts(Ajuna.NetApi.Model.Types.Base.BaseVec<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(4, "Balances", 6, "upgrade_accounts", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Transfer(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 7, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_set_balance
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceSetBalance(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> new_free)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(new_free.Encode());
            return new Method(4, "Balances", 8, "force_set_balance", byteArray.ToArray());
        }
    }
    
    public sealed class BalancesConstants
    {
        
        /// <summary>
        /// >> ExistentialDeposit
        ///  The minimum amount required to keep an account open. MUST BE GREATER THAN ZERO!
        /// 
        ///  If you *really* need it to be zero, you can enable the feature `insecure_zero_ed` for
        ///  this pallet. However, you do so at your own risk: this will open up a major DoS vector.
        ///  In case you have multiple sources of provider references, you may also get unexpected
        ///  behaviour if you set this to zero.
        /// 
        ///  Bottom line: Do yourself a favour and make it at least one!
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 ExistentialDeposit()
        {
            var result = new Ajuna.NetApi.Model.Types.Primitive.U128();
            result.Create("0xA0860100000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxLocks
        ///  The maximum number of locks that should exist on an account.
        ///  Not strictly enforced, but used for weight estimation.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxLocks()
        {
            var result = new Ajuna.NetApi.Model.Types.Primitive.U32();
            result.Create("0x40420F00");
            return result;
        }
        
        /// <summary>
        /// >> MaxReserves
        ///  The maximum number of named reserves that can exist on an account.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxReserves()
        {
            var result = new Ajuna.NetApi.Model.Types.Primitive.U32();
            result.Create("0x40420F00");
            return result;
        }
        
        /// <summary>
        /// >> MaxHolds
        ///  The maximum number of holds that can exist on an account at any time.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxHolds()
        {
            var result = new Ajuna.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxFreezes
        ///  The maximum number of individual freeze locks that can exist on an account at any time.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxFreezes()
        {
            var result = new Ajuna.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00000000");
            return result;
        }
    }
    
    public enum BalancesErrors
    {
        
        /// <summary>
        /// >> VestingBalance
        /// Vesting balance too high to send value.
        /// </summary>
        VestingBalance,
        
        /// <summary>
        /// >> LiquidityRestrictions
        /// Account liquidity restrictions prevent withdrawal.
        /// </summary>
        LiquidityRestrictions,
        
        /// <summary>
        /// >> InsufficientBalance
        /// Balance too low to send value.
        /// </summary>
        InsufficientBalance,
        
        /// <summary>
        /// >> ExistentialDeposit
        /// Value too low to create account due to existential deposit.
        /// </summary>
        ExistentialDeposit,
        
        /// <summary>
        /// >> Expendability
        /// Transfer/payment would kill account.
        /// </summary>
        Expendability,
        
        /// <summary>
        /// >> ExistingVestingSchedule
        /// A vesting schedule already exists for this account.
        /// </summary>
        ExistingVestingSchedule,
        
        /// <summary>
        /// >> DeadAccount
        /// Beneficiary account must pre-exist.
        /// </summary>
        DeadAccount,
        
        /// <summary>
        /// >> TooManyReserves
        /// Number of named reserves exceed `MaxReserves`.
        /// </summary>
        TooManyReserves,
        
        /// <summary>
        /// >> TooManyHolds
        /// Number of holds exceed `MaxHolds`.
        /// </summary>
        TooManyHolds,
        
        /// <summary>
        /// >> TooManyFreezes
        /// Number of freezes exceed `MaxFreezes`.
        /// </summary>
        TooManyFreezes,
    }
}
