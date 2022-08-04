using System.Collections;
using DevNcore.CBT.Models;

namespace DevNcore.CBT.Resources.Pages;

public partial class TestListPage : ContentPage
{
	public TestListPage()
	{
		InitializeComponent();

		cvList.ItemsSource = GetTestList();
	}

    private IEnumerable GetTestList()
    {
		var source = new List<TestModel>();
        source.Add(new TestModel { Name = "정보처리기능사" });
        source.Add(new TestModel { Name = "정보처리산업기사" });
        source.Add(new TestModel { Name = "정보처리기사" });
        source.Add(new TestModel { Name = "정보관리기술사" });
        source.Add(new TestModel { Name = "정보처리기사" });
        source.Add(new TestModel { Name = "정보기기운용기능사" });
        source.Add(new TestModel { Name = "정보기기운용기능사" });
        source.Add(new TestModel { Name = "멀티미디어콘텐츠제작전문가" });
        source.Add(new TestModel { Name = "컴퓨터그래픽스운용기능사" });
        source.Add(new TestModel { Name = "컴퓨터활용능력1급" });
        source.Add(new TestModel { Name = "컴퓨터활용능력2급" });
        source.Add(new TestModel { Name = "사무자동화산업기사" });
        source.Add(new TestModel { Name = "전자계산기조직응용기사" });
        source.Add(new TestModel { Name = "로봇소프트웨어개발기사" });
        source.Add(new TestModel { Name = "로봇하드웨어개발기사" });
        source.Add(new TestModel { Name = "전자기기기능사" });
        source.Add(new TestModel { Name = "전자기사" });
        source.Add(new TestModel { Name = "임베디드기사" });
        source.Add(new TestModel { Name = "멀티미디어콘텐츠제작전문가" });
        source.Add(new TestModel { Name = "컴퓨터그래픽스운용기능사" });
        source.Add(new TestModel { Name = "컴퓨터활용능력1급" });
        source.Add(new TestModel { Name = "컴퓨터활용능력2급" });
        source.Add(new TestModel { Name = "사무자동화산업기사" });
        source.Add(new TestModel { Name = "전자계산기조직응용기사" });
        source.Add(new TestModel { Name = "로봇소프트웨어개발기사" });
        source.Add(new TestModel { Name = "로봇하드웨어개발기사" });
        source.Add(new TestModel { Name = "전자기기기능사" });
        source.Add(new TestModel { Name = "전자기사" });
        source.Add(new TestModel { Name = "임베디드기사" });
        return source;
    }
}


