using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Atm
{
    internal class Account:IDisposable
    {
        protected decimal _saving = 0;
        public string Id { get; set; }
        public decimal Balance { get { return this._saving; } private set { } }

        /// <summary>
        /// 存款
        /// </summary>
        /// <returns></returns>
        public decimal Deposit(decimal cash)
        {
            this._saving += cash;
            return this._saving + cash;
        }

        public void Dispose()
        {
            this._saving = 0;
        }

        /// <summary>
        /// 提款
        /// </summary>
        /// <returns></returns>
        public virtual decimal Withdraw(decimal cash)
        {
            this._saving -= cash;
            return this._saving - cash;
        }
    }
}
