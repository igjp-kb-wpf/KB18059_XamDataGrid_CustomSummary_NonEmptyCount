using System;
using Infragistics.Windows.DataPresenter;

namespace KB18059_WpfApp1;

// XamDataGrid の SummaryDefinition で使用するカスタム集計計算クラスです
// デフォルトの Count は null・空文字・空白もカウントしてしまうため、
// このクラスでは「実際に値があるセルのみ」をカウントします
public class NonEmptyCountCalculator : SummaryCalculator
{

    private static NonEmptyCountCalculator? _instance;
    public static NonEmptyCountCalculator Instance => _instance ??= new NonEmptyCountCalculator();

    // カウンター（集計中に値があった行の数を保持します）
    private int _count;
    // SummaryDefinition の Calculator プロパティに表示される識別名
    public override string Name => "Non Empty Count";

    public override string Description => "値があるデータのみをカウント";

    // 処理可能なデータ型を指定（すべての型を対象にする）
    public override bool CanProcessDataType(Type dataType)
    {
        return true;
    }

    // 集計開始時にカウンターをリセット
    public override void BeginCalculation(SummaryResult summaryResult)
    {
        _count = 0;
    }

    // 各レコードで呼ばれ、値があるデータのみカウント
    public override void Aggregate(object dataValue, SummaryResult summaryResult, Record record)
    {
        if (dataValue != null && // null でないことを確認
            dataValue != DBNull.Value && // データベースの null でないことを確認
            !string.IsNullOrWhiteSpace(dataValue.ToString())) // 空文字や空白でないことを確認
        {
            _count++; // 値があるデータのみをカウント
        }
    }

    // 集計終了時に結果を返します
    public override object EndCalculation(SummaryResult summaryResult)
    {
        return _count;
    }
}