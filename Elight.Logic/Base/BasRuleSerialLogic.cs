using Elight.Entity.WanWei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Logic.Base
{
    public class BasRuleSerialLogic : BaseLogic
    {
        public  BasRuleSerial GetRuleSerial(string ruleName, string prefix)
        {
            using (var db = GetInstance())
            {
                return db.Queryable<BasRuleSerial>().Where(t => t.RULE_NAME == ruleName && t.PREFIX == prefix).First();
            }
        }

        public int CreateBarcode(List<WIP_SNRes> list, BasRuleSerial ruleSerial, string ruleCode, ref string msg)
        {
            using (var db = GetInstance())
            {
                try
                {
                    msg = "";
                    int row = 0;
                    db.Ado.BeginTran();

                    //1.修改或者新增最大流水码记录
                    BasRuleSerial serial = db.Queryable<BasRuleSerial>()
                        .Where(t => t.RULE_NAME == ruleSerial.RULE_NAME && t.PREFIX == ruleSerial.PREFIX).First();
                    if (serial == null)
                    {
                        row = db.Insertable<BasRuleSerial>(ruleSerial).ExecuteCommand();

                    }
                    else
                    {
                        row = db.Updateable<BasRuleSerial>(ruleSerial).ExecuteCommand();
                    }
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
                    }

                    //2.插入条码生成表
                    row = db.Insertable<WIP_SNRes>(list).ExecuteCommand();
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
                    }

                    //3.修改工单表的生码数量
                    row = db.Updateable<OrderInfo>()
                        .SetColumns(t => t.CreatedQty == t.CreatedQty + list.Count)
                        .SetColumns(t => t.SNRule == ruleCode)
                        .Where(t => t.OrderId == list[0].OrderId).ExecuteCommand();
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
                    }

                    db.Ado.CommitTran();
                    msg = "OK";
                    return row;
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    return -1;
                }
            }
        }

        public string GetNewCartonNo(string rulename, string prefix, ref string msg)
        {
            string cartonNo = "";

            using (var db = GetInstance())
            {
                msg = "";
                int row = 0;
                db.Ado.BeginTran();         

                BasRuleSerial serial = db.Queryable<BasRuleSerial>()
                        .Where(t => t.RULE_NAME == rulename && t.PREFIX == prefix).First();
                if(serial == null)
                {
                    BasRuleSerial basRule = new BasRuleSerial();
                    basRule.RULE_NAME = rulename;
                    basRule.PREFIX = prefix;
                    basRule.LAST_SEQNO = 1;
                    basRule.LAST_SERIALNO = "0001";

                    row = db.Insertable<BasRuleSerial>(basRule).ExecuteCommand();
                    if (row > 0)
                        cartonNo = prefix + basRule.LAST_SERIALNO;
                }
                else
                {
                    serial.LAST_SEQNO = serial.LAST_SEQNO + 1;
                    serial.LAST_SERIALNO = serial.LAST_SEQNO.ToString("0000");
                    row = db.Updateable<BasRuleSerial>(serial).ExecuteCommand();
                    if (row > 0)
                        cartonNo = prefix + serial.LAST_SERIALNO;
                }
                if (row > 0)
                {
                    db.Ado.CommitTran();
                    msg = "OK";
                }
                else
                {
                    db.Ado.RollbackTran();
                }
            }

            return cartonNo;
        }

        public string GetNewCartonNo2(string rulename, string front, ref string msg)
        {
            string cartonNo = "";

            using (var db = GetInstance())
            {
                msg = "";
                int row = 0;
                db.Ado.BeginTran();

                //获取服务器的当前日期：yyyyMMdd
                string prefix = "";     //箱号的固定前缀，除流水号之外的值
                string sql = "SELECT REPLACE(CONVERT(varchar, GETDATE(), 112), '-', '') AS cur_date";
                prefix = front.Trim() + db.Ado.GetString(sql).Trim();

                BasRuleSerial serial = db.Queryable<BasRuleSerial>()
                        .Where(t => t.RULE_NAME == rulename && t.PREFIX == prefix).First();
                if (serial == null)
                {
                    BasRuleSerial basRule = new BasRuleSerial();
                    basRule.RULE_NAME = rulename;
                    basRule.PREFIX = prefix;
                    basRule.LAST_SEQNO = 1;
                    basRule.LAST_SERIALNO = "0001";

                    row = db.Insertable<BasRuleSerial>(basRule).ExecuteCommand();
                    if (row > 0)
                        cartonNo = prefix + basRule.LAST_SERIALNO;
                }
                else
                {
                    serial.LAST_SEQNO = serial.LAST_SEQNO + 1;
                    serial.LAST_SERIALNO = serial.LAST_SEQNO.ToString("0000");
                    row = db.Updateable<BasRuleSerial>(serial).ExecuteCommand();
                    if (row > 0)
                        cartonNo = prefix + serial.LAST_SERIALNO;
                }
                if (row > 0)
                {
                    db.Ado.CommitTran();
                    msg = "OK";
                }
                else
                {
                    db.Ado.RollbackTran();
                }
            }

            return cartonNo;
        }


        public int CreateBarcodeBox(List<WIP_PackagingBox> list, BasRuleSerial ruleSerial, ref string msg)
        {
            using (var db = GetInstance())
            {
                try
                {
                    msg = "";
                    int row = 0;
                    db.Ado.BeginTran();

                    //1.修改或者新增最大流水码记录
                    BasRuleSerial serial = db.Queryable<BasRuleSerial>()
                        .Where(t => t.RULE_NAME == ruleSerial.RULE_NAME && t.PREFIX == ruleSerial.PREFIX).First();
                    if (serial == null)
                    {
                        row = db.Insertable<BasRuleSerial>(ruleSerial).ExecuteCommand();

                    }
                    else
                    {
                        row = db.Updateable<BasRuleSerial>(ruleSerial).ExecuteCommand();
                    }
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
                    }

                    //2.插入条码生成表
                    row = db.Insertable<WIP_PackagingBox>(list).ExecuteCommand();
                    if (row == 0)
                    {
                        db.Ado.RollbackTran();
                        return row;
                    }
                    

                    db.Ado.CommitTran();
                    msg = "OK";
                    return row;
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    return -1;
                }
            }
        }

    }
}
