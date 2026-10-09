using PSI.Common;
using PSI.Models.DModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPSI
{
        public static class FormUtility
        {


                /// <summary>
                /// try  catch 异常处理
                /// </summary>
                /// <param name="act"></param>
                /// <param name="message"></param>
                public static void TryCatch(this Action act, string message)
                {
                        try
                        {
                                act.Invoke();
                        }
                        catch (Exception ex)
                        {
                                MsgBoxHelper.MsgErrorShow(ex.Message);
                        }
                }

                /// <summary>
                /// 关闭显示在选择卡中的窗体
                /// </summary>
                /// <param name="form"></param>
                public static void CloseForm(this Form form)
                {
                        if (!form.TopLevel)
                        {
                                TabPage tp = form.Parent as TabPage;
                                TabControl tc = tp.Parent as TabControl;
                                tc.TabPages.Remove(tp);
                        }
                        form.Close();

                }

                /// <summary>
                /// 判断Form是否已打开
                /// </summary>
                /// <param name="formName"></param>
                /// <returns></returns>
                public static bool CheckOpenForm(string formName)
                {
                        bool bResult = false;
                        foreach (Form frm in Application.OpenForms)
                        {
                                if (frm.Name == formName)
                                {
                                        bResult = true;
                                        break;
                                }
                        }
                        return bResult;
                }

                /// <summary>
                /// 关闭指定的窗体
                /// </summary>
                /// <param name="formName"></param>
                public static void CloseOpenForm(string formName)
                {
                        foreach (Form frm in Application.OpenForms)
                        {
                                if (frm.Name == formName)
                                {
                                        frm.Close();
                                        break;
                                }
                        }
                }

                public static void ShowOpenForm(string formName)
                {
                        foreach (Form frm in Application.OpenForms)
                        {
                                if (frm.Name == formName)
                                {
                                        if (!frm.Visible)
                                                frm.Show();
                                        frm.Activate();
                                        break;
                                }
                        }
                }

                /// <summary>
                /// 添加窗体页面到选项卡中
                /// </summary>
                /// <param name="tab"></param>
                /// <param name="form"></param>
                public static void AddTabFormPage(this TabControl tab, Form form)
                {
                        form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        form.TopLevel = false;
                        form.Dock = DockStyle.Fill;
                        form.WindowState = FormWindowState.Maximized;
                        TabPage page = new TabPage();
                        page.Controls.Add(form);
                        page.Name = form.Name;
                        page.Text = form.Text;
                        page.Width = form.Width;
                        page.Height = form.Height;
                        tab.TabPages.Add(page);
                        tab.SelectedTab = page;
                        form.Show();
                }

                /// <summary>
                /// 移除已删除的数据
                /// </summary>
                /// <typeparam name="T"></typeparam>
                /// <param name="dgv"></param>
                /// <param name="delList"></param>
                public static void RefreshDgv<T>(this DataGridView dgv, List<T> delList) where T : class
                {
                        List<T> list = dgv.DataSource as List<T>;
                        dgv.DataSource = null;
                        foreach (var r in delList)
                        {
                                list.Remove(r);
                        }
                        dgv.DataSource = list;
                }

                /// <summary>
                /// 创建TreeView节点
                /// </summary>
                /// <param name="tName"></param>
                /// <param name="nText"></param>
                /// <returns></returns>
                public static TreeNode CreateNode(string tName, string nText)
                {
                        TreeNode tn = new TreeNode();
                        tn.Name = tName;
                        tn.Text = nText;
                        return tn;
                }

                /// <summary>
                /// 递归加载单位类别节点
                /// </summary>
                /// <param name="list"></param>
                /// <param name="pNode"></param>
                /// <param name="pId"></param>
                public static void AddTvUTypesNode(List<UnitTypeInfoModel> list, TreeNode pNode, int pId)
                {
                        var pList = list.Where(ut => ut.ParentId == pId);
                        foreach (UnitTypeInfoModel ut in pList)
                        {
                                TreeNode node = FormUtility.CreateNode(ut.UTypeId.ToString(), ut.UTypeName);
                                pNode.Nodes.Add(node);
                                AddTvUTypesNode(list, node, ut.UTypeId);
                        }
                }

                /// <summary>
                /// 递归加载商品类别节点
                /// </summary>
                /// <param name="list"></param>
                /// <param name="pNode"></param>
                /// <param name="pId"></param>
                public static void AddTvGTypesNode(List<GoodsTypeInfoModel> list, TreeNode pNode, int pId)
                {
                        var pList = list.Where(ut => ut.ParentId == pId);
                        foreach (GoodsTypeInfoModel gt in pList)
                        {
                                TreeNode node = FormUtility.CreateNode(gt.GTypeId.ToString(), gt.GTypeName);
                                pNode.Nodes.Add(node);
                                AddTvGTypesNode(list, node, gt.GTypeId);
                        }
                }

                /// <summary>
                /// 加载仓库类别节点
                /// </summary>
                /// <param name="list"></param>
                /// <param name="pNode"></param>
                public static void AddTvSTypesNode(List<StoreTypeInfoModel> list, TreeNode pNode)
                {
                        foreach (StoreTypeInfoModel type in list)
                        {
                                TreeNode node = FormUtility.CreateNode(type.STypeId.ToString(), type.STypeName);
                                pNode.Nodes.Add(node);
                        }
                }

                /// <summary>
                /// 获取删除操作的名称
                /// </summary>
                /// <param name="isDeleted"></param>
                /// <returns></returns>
                public static string GetDeleteTypeName(int isDeleted)
                {
                        string typeName = "";
                        switch(isDeleted)
                        {
                                case 1:typeName = "删除";break;
                                case 0: typeName = "恢复"; break;
                                case 2: typeName = "移除"; break;
                                default:break;
                        }
                        return typeName;
                }

                /// <summary>
                /// 将DataGridView中数据导出到Excel
                /// </summary>
                /// <typeparam name="T"></typeparam>
                /// <param name="list"></param>
                /// <param name="dgv"></param>
                /// <param name="fileName"></param>
                /// <param name="sheetName"></param>
                /// <param name="msg"></param>
                /// <param name="title"></param>
                public static void DataToExcel<T>(List<T> list, DataGridViewColumnCollection cols, string fileName, string sheetName, string msg, string title)
                {
                        if (list != null && list.Count > 0)
                        {
                                string filePath = "";
                                FolderBrowserDialog fbdChoose = new FolderBrowserDialog();
                                if (fbdChoose.ShowDialog() == DialogResult.OK)
                                {
                                        filePath = fbdChoose.SelectedPath;
                                }
                                if (string.IsNullOrEmpty(filePath))
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择导出的位置！");
                                        return;
                                }
                                if (filePath.LastIndexOf('/') != filePath.Length - 1)
                                        filePath += "/";
                                Dictionary<string, string> colsName = new Dictionary<string, string>();
                                foreach (DataGridViewColumn dc in cols)
                                {
                                        colsName.Add(dc.Name, dc.HeaderText);
                                }
                                int count = ExcelHelper.ListToExcel<T>(list, filePath + fileName, sheetName, colsName);
                                if (count > 0)
                                        MsgBoxHelper.MsgBoxShow(title, msg + "数据导出成功！");
                                else
                                {
                                        MsgBoxHelper.MsgErrorShow(msg + "数据导出失败！");
                                }
                        }
                        else
                        {
                                MsgBoxHelper.MsgErrorShow("没有数据可导出！");
                                return;
                        }
                }
        }
}
