using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillDomain.Entity;
using BillDomain.Repository.Class;

namespace LazyAccount.Models
{
    public class BillModel:BillMain
    {
        public IList<BillDetail> BillDetailList { get; set; }

        public BillModel()
        {
            this.BillDate = DateTime.Now.ToString("yyyy-MM-dd");
            this.BillDetailList = GenerateBillDetailList();
        }

        public bool AddBill(BillModel model)
        {
            BillMainRepository _billMainRepository = new BillMainRepository();
            BillDetailRepository _billDetailRepository = new BillDetailRepository();
            BillMain _billMain = new BillMain();
            _billMain.BillDate = model.BillDate;
            _billMain.BillMemo = model.BillMemo;
            _billMain.CreateDate = DateTime.Now;
            _billMain.CreateUser = "";
            _billMain.ModifyDate = DateTime.Now;
            _billMain.ModifyUser = "";
            _billMain.TenantId = "";
            _billMainRepository.Add(_billMain);

            foreach (var item in model.BillDetailList)
            {
                BillDetail _billDetail = new BillDetail();
                _billDetail.BillId = _billMain.Id;
                _billDetail.BillMoney = item.BillMoney;
                _billDetail.ItemBudget = item.ItemBudget;
                _billDetail.ItemGroup = item.ItemGroup;
                _billDetail.ItemId = item.ItemId;
                _billDetail.ItemName = item.ItemName;
                _billDetailRepository.Add(_billDetail);
            }            
            return true;
        }

        public IList<BillDetail> GenerateBillDetailList()
        {
            IList<BillDetail> _bill = new List<BillDetail>();
            ItemRepository _itemRepository = new ItemRepository();
            foreach (Item _item in _itemRepository.GetAll())
            {
                _bill.Add(new BillDetail
                {
                    BillId = 0,
                    BillMoney = 0,
                    ItemBudget = _item.ItemBudget,
                    ItemGroup = _item.ItemGroup,
                    ItemId = _item.Id,
                    ItemName = _item.ItemName
                });
            }
            return _bill;
        }
    }
}