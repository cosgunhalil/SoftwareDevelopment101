
namespace SD101.Example.IENumerable
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;
    using SD101.Common;

    public class EnumerableExample : IExample
    {
        private IEnumerator countCoroutine;

        public void Execute()
        {
            //ExecuteIEnumeratorPart1();
            //ExecuteIEnumeratorPart2();
            ExecuteCoroutineExample();
        }

        private void ExecuteIEnumeratorPart1()
        {
            List<string> words = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                words.Add("Item " + i.ToString());
            }

            IEnumerator<string> enumerator = words.GetEnumerator();

            //output?
            enumerator.MoveNext();
            Debug.Log(enumerator.Current);
            enumerator.MoveNext();
            Debug.Log(enumerator.Current);
            enumerator.Reset();  //index = -1
            Debug.Log(enumerator.Current);
            enumerator.MoveNext();
            Debug.Log(enumerator.Current);
        }

        private void ExecuteIEnumeratorPart2()
        {
            Debug.Log("Music Box started!");

            MusicBox musicBox = new MusicBox();
            var playList = musicBox.GetEnumerator();

            while (playList.MoveNext())
            {
                Debug.Log(playList.Current);
            }

            Debug.Log("Music Box finished!");

        }

        private void ExecuteCoroutineExample()
        {
            countCoroutine = CountCoroutine();

            CentralEventManager.Instance.GetCoroutineEventsManager().
                AddEvent(new Services.Coroutine.CoroutineEvent() {
                    enumerator = countCoroutine
                });
        }

        private IEnumerator CountCoroutine()
        {
            var wait = new WaitForSeconds(.1f);

            Debug.Log("Count Started!");

            for (int i = 0; i < 10; i++)
            {
                Debug.Log(i);
                yield return wait;
            }

            Debug.Log("Count Finished!");
        }

    }

    public class PlayList : IEnumerator<string>
    {
        private List<string> songList = new List<string>();
        private int index = -1;

        public PlayList()
        {
            songList = new List<string> {
                "Tum Rakak",
                "Anlamı Yok",
                "Justice"
            };
        }

        public string Current
        {
            get
            {
                if (index < 0)
                {
                    return null;
                }
                else
                {
                    return songList[index];
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return null;
            }
        }

        public void Dispose()
        {
            songList.Clear();
        }

        public bool MoveNext()
        {
            if (index < songList.Count - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Reset()
        {
            index = -1;
        }
    }

    public class MusicBox : IEnumerable<string>
    {
        PlayList playList = new PlayList();

        public IEnumerator<string> GetEnumerator()
        {
            return playList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}


