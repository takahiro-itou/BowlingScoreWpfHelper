//  -*-  coding: utf-8-with-signature-unix     -*-  //
/*************************************************************************
**                                                                      **
**                  ---  Bowling  Score  Project.  ---                  **
**                                                                      **
**          Copyright (C), 2025-2026, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/

using   BowlingScoreHelper.ViewModels;


namespace  BowlingScoreHelper.Services  {

//========================================================================
//
//    IWindowService  interface.
//

public  interface  IWindowService  {


//----------------------------------------------------------------
/**   ファイルを開くダイアログを表示する。
**
**/
public  System.String?
showOpenFileDialog(
        OpenFileDialogSettings  settings);

//----------------------------------------------------------------
/**   名前を付けて保存ダイアログを表示する。
**
**/
public  System.String?
showSaveFileDialog(
        SaveFileDialogSettings  settings);


}   //  End interface  IWindowService

}   //  End of namespace  BaseballScoreHelper.Services
