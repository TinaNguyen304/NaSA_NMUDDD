package nasanotes.nasanotes;

import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.Context;
import android.os.SystemClock;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.content.Intent;


public class MainActivity extends AppCompatActivity {

    private Button RecDel;
    private Button del;
    private Button newnote;

    private PendingIntent mAlarmIntent;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



        RecDel = (Button) findViewById(R.id.RecDel);
        newnote = (Button) findViewById(R.id.newnote);
        del = (Button) findViewById(R.id.del);

        RecDel.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view) {
                Intent intent;
                intent = new Intent(MainActivity.this, RecentlyDelete.class  );
                startActivity(intent);
            }

        });

        newnote.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent;
                intent = new Intent(MainActivity.this, NewNote.class  );
                startActivity(intent);
            }
        });
    }
}
