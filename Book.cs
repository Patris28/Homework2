namespace LibrarySystem {
public class Book{
string title;
string author;
int pages;
bool isCheckedOut;

public void CheckOut(){
    isCheckedOut=true;
}
public void ReturnBook(){
    isCheckedOut=false;
}

 public Book( string title, string author){
    this.title = title;
    this.author=author;
    pages=100;
    isCheckedOut=false;
}


public Book( string title, string author, int pages){
    this.title = title;
    this.author=author;
    this.pages=pages;
    isCheckedOut=false;
}

        public override string ToString()
        {
            return "Title:"+title+", Author:"+author+", Pages:"+pages+", Checked Out:"+isCheckedOut;

        }
    }
}