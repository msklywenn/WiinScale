#include "wiiuse.h"

#define MAX_WIIMOTES 5
static wiimote** wiimotes;
static int board;

__declspec(dllexport) int wiiuse_board_init()
{
	wiimotes = wiiuse_init(MAX_WIIMOTES);
	int count = wiiuse_find(wiimotes, MAX_WIIMOTES, 5);
	count = wiiuse_connect(wiimotes, count);
	board = -1;
	for (int i = 0; i < count; i++)
		if (board == -1 && wiimotes[i]->exp.type == EXP_WII_BOARD)
			board = i;
		else
			wiiuse_disconnect(wiimotes[i]);
			
	if (board == -1)
		wiiuse_cleanup(wiimotes, MAX_WIIMOTES);

	return board != -1;
}

__declspec(dllexport) int wiiuse_board_read(float* weight, float* x, float* y)
{
	int read = 0;
	if (board != -1)
	{
		while (wiiuse_poll(wiimotes, MAX_WIIMOTES))
		{
			switch (wiimotes[board]->event)
			{
				case WIIUSE_EVENT:
				{
					struct wii_board_t* wb = (wii_board_t*)&wiimotes[board]->exp.wb;
					*weight = wb->tl + wb->tr + wb->bl + wb->br;
					*x = ((wb->tr + wb->br) / *weight) * 2 - 1;
					*y = ((wb->tl + wb->tr) / *weight) * 2 - 1;
					read++;
					break;
				}

				case WIIUSE_WII_BOARD_CTRL_REMOVED:
				case WIIUSE_DISCONNECT:
				case WIIUSE_UNEXPECTED_DISCONNECT:
				{
					return 0;
					break;
				}
			}
		}
	}
	return read;
}

__declspec(dllexport) void wiiuse_board_shutdown()
{
	if (board != -1 && wiimotes[board]->state == WIIMOTE_STATE_CONNECTED)
		wiiuse_disconnect(wiimotes[board]);
	wiiuse_cleanup(wiimotes, MAX_WIIMOTES);
	wiimotes = 0;
	board = -1;
}
